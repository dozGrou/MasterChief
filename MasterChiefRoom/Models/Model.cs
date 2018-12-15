using System.Collections.Generic;

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

        public Model()
        {
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
    }
}