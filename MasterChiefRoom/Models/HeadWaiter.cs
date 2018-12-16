using System;
using System.Collections.Generic;
using System.Linq;
using MasterChiefRoom.Recipes;

namespace MasterChiefRoom.Models
{
    public class HeadWaiter : Entity
    {
        private Model Model { get; set; }

        public HeadWaiter(Model model)
        {
            this.Model = model;
        }
        
        public override void Tick()
        {
            
        }

        public void NotifyNewClientsArrived(List<Client> clients)
        {
            Table tableFree = this.Model.Tables.First(table => !table.Clients.Any());

            tableFree.Clients = clients;
            Console.WriteLine("{0} Clients assigned to table : {1}", clients.Count, tableFree.GetHashCode());

            this.AskMealToClients(tableFree);
        }

        private void AskMealToClients(Table table)
        {
            Order order = new Order();
            order.TableId = table.GetHashCode();
            
            for (int i = 0; i < table.Clients.Count; i++)
            {
                Recipe recipe = Recipe.Recipes[(new Random()).Next(Recipe.Recipes.Count)];
                
                order.Recipes.Add(recipe);
            }
            
            //Notify the kitchen new order
        }
    }
}