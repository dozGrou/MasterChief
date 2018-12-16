using System;
using System.Collections.Generic;
using MasterChief.Recipes;

namespace MasterChief.Models
{
    [Serializable]
    public class Order
    {
        public int TableId { get; set; }
        public List<Recipe> Recipes { get; set; }
        public List<Plate> Plates { get; set; }
        
        public Order()
        {
            Console.WriteLine("Order {0} received", this.GetHashCode().ToString());
            Recipes = new List<Recipe>();
            Plates = new List<Plate>();
        }
    }
}