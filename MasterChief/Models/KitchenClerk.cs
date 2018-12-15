using System;
using System.Collections.Generic;
using MasterChief.Tools;

namespace MasterChief.Models
{
    public class KitchenClerk : Entity, IObserverCook<Plate>, IObservable<Chef, Plate>
    {
        public Model Model { get; set; }
        private readonly List<Chef> _chefs = new List<Chef>();

        public KitchenClerk(Model model)
        {
            this.Model = model;
        }

        public override void Tick()
        {

        }

        public void Update(Plate plate)
        {
            this.RecipeEnded(plate);
        }

        public void UpdateCleanTools(List<Tool> tools)
        {
            this.Model.Cleaner.WashTools(tools);
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