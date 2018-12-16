using System;
using System.Collections.Generic;
using System.Linq;
using MasterChiefRoom.Recipes;

namespace MasterChiefRoom.Models
{
    public class Waiter : Entity
    {
        public Model Model { get; set; }

        public Waiter(Model model)
        {
            Model = model;
        }
        
        public override void Tick()
        {
            
        }

        public void BringOrderToClients(Order order)
        {
            Table table = this.Model.Tables.First(t => t.GetHashCode() == order.TableId);
            
            foreach (Client client in table.Clients)
            {
                client.Plate = order.Plates.First();
                Console.WriteLine("Client {0} received his plate {1} with the recipe {2}", client.GetHashCode(), client.Plate.GetHashCode(), client.Plate.Recipe.GetType().Name);
                
                order.Plates.Remove(order.Plates.First());
            }
        }

        public void AskMealToClients(Table table)
        {
            Order order = new Order {TableId = table.GetHashCode()};
            Random random = new Random();

            for (int i = 0; i < table.Clients.Count; i++)
            {
                Recipe recipe = Recipe.Recipes[random.Next(Recipe.Recipes.Count)];
                
                order.Recipes.Add(recipe);
            }
            
            //Notify the kitchen new order
            Console.WriteLine("Order {0} has been sent to the kitchen", order.GetHashCode());
            //Temp without sockets
            foreach (Recipe recipe in order.Recipes)
            {
                order.Plates.Add(new Plate(recipe));
            }
            this.BringOrderToClients(order);
        }

        public void NotifyMealEnd(Table table)
        {
            bool everybodyFinishedHisMeal = true;

            foreach (Client client in table.Clients)
            {
                if (client.Plate == null) continue;
                
                everybodyFinishedHisMeal = false;
                break;
            }
            
            if(everybodyFinishedHisMeal)
                this.CleanTable(table);
        }

        private void CleanTable(Table table)
        {
            if (table.Clients.Any())
            {
                table.Clients = new List<Client>(); //Cleaning old clients
                Console.WriteLine("Table {0} has been cleaned", table.GetHashCode());
                Console.WriteLine("{0} free table left", this.Model.CountFreeTablesLeft());
            }
        }
    }
}