using System.Collections.Generic;
using MasterChief.Recipes;

namespace MasterChief.Models
{
    public class Model
    {
        private readonly List<Entity> _entities = new List<Entity>();
        public List<Entity> Entities
        {
            get { return _entities; }
        }

        public Model()
        {
            List<KitchenClerk> kitchenClerks = new List<KitchenClerk>
            {
                new KitchenClerk(),
                new KitchenClerk(),
            };
            List<Cook> cooks = new List<Cook>
            {
                new Cook(),
                new Cook(),
            };
            Chef chef = new Chef(cooks);

            foreach (KitchenClerk kitchenClerk in kitchenClerks)
            {
                foreach (Cook cook in cooks)
                {
                    cook.Attach(kitchenClerk);
                    Entities.Add(cook);
                }
                kitchenClerk.Attach(chef);
                Entities.Add(kitchenClerk);
            }
            
            Entities.Add(chef);
            
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
//            chef.AssignOrder(order);
        }
    }
}