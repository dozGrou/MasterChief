using System;
using System.Collections.Generic;
using System.Linq;
using MasterChief.Recipes;

namespace MasterChief.Models
{
    public class Chef : Entity, IObserver<Plate>
    {
        public List<Cook> Cooks { get; set; }
        public List<Order> Orders { get; set; }

        public Chef(List<Cook> cooks)
        {
            Cooks = cooks;
            Orders = new List<Order>();
        }
        
        public void AssignOrder(Order order)
        {
            Orders.Add(order);
            
            foreach (Recipe recipe in order.Recipes)
            {
                if (!Cooks.Any())
                    return;
                
                Cook minimumRecipeCook = null;
                foreach (Cook cook in Cooks)
                {
                    if (minimumRecipeCook == null)
                        minimumRecipeCook = cook;
                    else
                    {
                        if (cook.Recipes.Count < minimumRecipeCook.Recipes.Count)
                            minimumRecipeCook = cook;
                    }
                }

                if (minimumRecipeCook != null)
                {
                    minimumRecipeCook.Recipes.Add(recipe);
                    Console.WriteLine("A recipe has been assigned to the cook : {0}", minimumRecipeCook.GetHashCode().ToString());
                }
            }
        }
        
        public override void Tick()
        {
            
        }

        public void Update(Plate plate)
        {
            Order orderOwner = null; 
            foreach (Order order in Orders)
            {
                if (order.GetHashCode() != plate.Recipe.OrderId) continue;
                
                orderOwner = order;
                break;
            }

            if (orderOwner == null)
                return;

            orderOwner.Plates.Add(plate);

            if (this.CheckIfOrderFinished(orderOwner))
            {
                Console.WriteLine("Order {0} has been finished, ready to be sent to the room", orderOwner.GetHashCode().ToString());
                //Notify Room with order
            }
        }

        private bool CheckIfOrderFinished(Order order)
        {
            List<Recipe> recipes = order.Recipes;
            List<Plate> plates = order.Plates;

            if (recipes.Count != plates.Count)
                return false;

            return true;
        }
    }
}