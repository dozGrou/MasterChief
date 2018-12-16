using System;

namespace MasterChiefRoom.Models
{
    public class Client : Entity
    {
        public int TimeToEat = 90 * 60;
        public int TimeRemainingToEat { get; set; }
        public Plate Plate { get; set; }
        
        public Table Table { get; set; }
        public Waiter Waiter { get; set; }

        public Client()
        {
            TimeRemainingToEat = TimeToEat;
            Plate = null;
        }
        
        public override void Tick()
        {
            if (Plate != null)
            {
                TimeRemainingToEat--;

                if (TimeRemainingToEat <= 0)
                {
                    Console.WriteLine("Client {0} finished eating the plate {1} with the recipe {2}", this.GetHashCode(), this.Plate.GetHashCode(), this.Plate.Recipe.GetType().Name);
                    Plate = null;
                    
                    this.Waiter.NotifyMealEnd(this.Table);
                }
            }
        }
    }
}