using System.Collections.Generic;
using MasterChief.Recipes;

namespace MasterChief.Models
{
    public class Model
    {
        private static Model _instance = null;
        public static Model Instance
        {
            get
            {
                return _instance ?? (_instance = new Model());
            }
        }

        private readonly List<Entity> _entities = new List<Entity>();
        public List<Entity> Entities
        {
            get { return _entities; }
        }
        public Chef Chef { get; set; }
        public Cleaner Cleaner { get; set; }

        private Model()
        {
            Cleaner = new Cleaner();
            List<KitchenClerk> kitchenClerks = new List<KitchenClerk>
            {
                new KitchenClerk(_instance),
                new KitchenClerk(_instance),
            };
            List<Cook> cooks = new List<Cook>
            {
                new Cook(),
                new Cook(),
            };
            Chef = new Chef(cooks);

            foreach (KitchenClerk kitchenClerk in kitchenClerks)
            {
                foreach (Cook cook in cooks)
                {
                    cook.Attach(kitchenClerk);
                    Entities.Add(cook);
                }
                kitchenClerk.Attach(Chef);
                Entities.Add(kitchenClerk);
            }
            
            Entities.Add(Chef);
            
//            Order order = new Order();
//            Recipe recipe = new AppleIceCream();
//            recipe.OrderId = order.GetHashCode();
//            order.Recipes.Add(recipe);
//            
//            recipe = new BananaSplit();
//            recipe.OrderId = order.GetHashCode();
//            order.Recipes.Add(recipe);
//            
//            recipe = new AppleIceCream();
//            recipe.OrderId = order.GetHashCode();
//            order.Recipes.Add(recipe);
//            
//            recipe = new AppleIceCream();
//            recipe.OrderId = order.GetHashCode();
//            order.Recipes.Add(recipe);
//            
//            recipe = new BananaSplit();
//            recipe.OrderId = order.GetHashCode();
//            order.Recipes.Add(recipe);
//            
//            Chef.AssignOrder(order);
        }
    }
}