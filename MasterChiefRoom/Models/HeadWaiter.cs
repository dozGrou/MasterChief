using System;
using System.Collections.Generic;
using System.Linq;

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
        }
    }
}