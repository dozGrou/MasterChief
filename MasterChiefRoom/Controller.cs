using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MasterChiefRoom.Models;

namespace MasterChiefRoom
{
    public class Controller
    {
        private readonly Model _model = new Model();
        
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
                    this.GenerateNewClient();
                    this.UpdateEntities();
                
                    Thread.Sleep(sleeper.Period);
                }
            }

        }

        private void GenerateNewClient()
        {
            bool anyTableEmpty = true;
            foreach (Table table in this._model.Tables)
            {
                if(table.Clients.Any())
                    continue;

                anyTableEmpty = false;
                break;
            }

            if (anyTableEmpty)
                return;
            
            Random random = new Random();
            if(random.Next(500) == 0) // One chance on 500
            {
                List<Client> clients = new List<Client>();

                int rand = random.Next(10);
                if (rand == 0) return;
                for (int i = 0; i < rand; i++)
                {
                    clients.Add(new Client());
                }
                
                this._model.HeadWaiter.NotifyNewClientsArrived(clients);
                Console.WriteLine("New clients arrived : {0}", clients.Count);
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