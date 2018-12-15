using System.Collections.Generic;

namespace MasterChiefRoom.Models
{
    public class Table
    {
        public List<Client> Clients { get; set; }

        public Table()
        {
            Clients = new List<Client>();
        }
    }
}