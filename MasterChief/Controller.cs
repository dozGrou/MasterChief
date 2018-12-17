using System;
using System.Globalization;
using System.Threading;
using MasterChief.Models;

namespace MasterChief
{
    public class Controller
    {
        private readonly Model _model = Model.Instance;

        public Controller()
        {
            (new Thread(AsynchronousSocketListener.StartListening))
                .Start();
        }
        
        public void Run()
        {
            Sleeper sleeper = Sleeper.Instance;

            while (!sleeper.IsEnd)
            {
                this.ListenKeys();
                
                if (sleeper.IsPaused)
                {
                    if (Console.ReadKey().Key == ConsoleKey.P)
                        sleeper.IsPaused = false;
                }
                else
                {
                    this.UpdateEntities();
                
                    Thread.Sleep(sleeper.Period);
                }
            }

        }

        private void UpdateEntities()
        {
            foreach (Entity entity in this._model.Entities)
            {
                entity.Tick();
            }
        }

        private void ListenKeys()
        {
            if (!Console.KeyAvailable) return;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.P:
                    this.Pause();
                    break;
                case ConsoleKey.A:
                    this.ToggleSpeed();
                    break;
                case ConsoleKey.Escape:
                    this.End();
                    break;
            }
        }

        private void Pause()
        {
            Sleeper.Instance.IsPaused = true;
            Console.WriteLine();
        }

        private void ToggleSpeed()
        {
            Sleeper.Instance.Interval =
                Sleeper.Instance.Interval == 1 ? 60 : 1;
            Console.WriteLine();
        }

        private void End()
        {
            Sleeper.Instance.IsEnd = true;
            Console.WriteLine();
        }
    }
}