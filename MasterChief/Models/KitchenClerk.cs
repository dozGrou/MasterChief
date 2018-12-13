using System;
using System.Collections.Generic;

namespace MasterChief.Models
{
    public class KitchenClerk : Entity, IObserver<Plate>, IObservable<Chef, Plate>
    {
        private readonly List<Chef> _chefs = new List<Chef>();
        
        public override void Tick()
        {

        }

        public void Update(Plate plate)
        {
            this.RecipeEnded(plate);
        }

        private void RecipeEnded(Plate plate)
        {
            this.Notify(plate);
        }

        public void Attach(Chef observer)
        {
            this._chefs.Add(observer);
        }

        public void Detach(Chef observer)
        {
            this._chefs.Remove(observer);
        }

        public void Notify(Plate plate)
        {
            foreach (Chef chef in this._chefs)
            {
                chef.Update(plate);
            }
        }
    }
}