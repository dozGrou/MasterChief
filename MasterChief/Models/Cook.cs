using System;
using System.Collections.Generic;
using System.Linq;
using MasterChief.Recipes;

namespace MasterChief.Models
{
    public class Cook : Entity, IObservable<KitchenClerk, Plate>
    {
        public List<Recipe> Recipes { get; set; }
        private const int TimeToPrepareRecipe = 5 * 60; //minutes * seconds
        private int TimeRemainingPrepareRecipe { get; set; }
        
        private readonly List<KitchenClerk> _kitchenClerks = new List<KitchenClerk>();

        public Cook()
        {
            Recipes = new List<Recipe>(); 
            TimeRemainingPrepareRecipe = TimeToPrepareRecipe;
        }

        public override void Tick()
        {
            if (this.Recipes.Any())
            {
                TimeRemainingPrepareRecipe--;
                if (TimeRemainingPrepareRecipe <= 0)
                {
                    Console.WriteLine("Cook {0} terminated recipe : {1}", this.GetHashCode().ToString(), Recipes.First().GetType().Name);
                    this.RecipeEnded();
                }
            }
        }

        private void RecipeEnded()
        {
            this.Notify(new Plate(this.Recipes.First())); //Notify kitchen clerk that the plate is ready
            TimeRemainingPrepareRecipe = TimeToPrepareRecipe; //Reinitialize timer
            Recipes.Remove(Recipes.First()); //Remove recipe already done
        }

        public void Attach(KitchenClerk observer)
        {
            this._kitchenClerks.Add(observer);
        }

        public void Detach(KitchenClerk observer)
        {
            this._kitchenClerks.Add(observer);
        }

        public void Notify(Plate plate)
        {
            this.GetKitchenClerkFree().Update(plate);
        }

        private KitchenClerk GetKitchenClerkFree()
        {
            int random = (new Random()).Next(1, _kitchenClerks.Count);
            return _kitchenClerks[random];
        }
    }
}