using System.Collections.Generic;
using System.Linq;

namespace MasterChiefRoom.Models
{
    public class Model
    {
        private readonly List<Entity> _entities = new List<Entity>();
        public List<Entity> Entities
        {
            get { return _entities; }
        }
        
        public List<Table> Tables { get; set; }
        public HeadWaiter HeadWaiter { get; set; }
        public Waiter Waiter { get; set; }

        public Model()
        {
            this.Waiter = new Waiter(this);
            this.HeadWaiter = new HeadWaiter(this);
            this.Entities.Add(this.HeadWaiter);
            this.Tables = new List<Table>
            {
                new Table(),
                new Table(),
                new Table(),
                new Table(),
                new Table(),
                new Table(),
                new Table(),
                new Table(),
                new Table(),
                new Table(),
            };
        }

        public int CountFreeTablesLeft()
        {
            return this.Tables.Count(table => table.Clients.Count == 0);
        }
    }
}