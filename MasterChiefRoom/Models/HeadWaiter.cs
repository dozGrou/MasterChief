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
            foreach (Client client in clients)
            {
                client.Table = tableFree;
            }
            Console.WriteLine("{0} Clients assigned to table : {1}", clients.Count, tableFree.GetHashCode());
            Console.WriteLine("{0} free tables left", this.Model.CountFreeTablesLeft());

            this.Model.Waiter.AskMealToClients(tableFree);
        }
    }
}