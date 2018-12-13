using System;
using System.Collections.Generic;
using MasterChief.Recipes;

namespace MasterChief.Models
{
    public class Order
    {
        public Order()
        {
            Console.WriteLine("Order {0} received", this.GetHashCode().ToString());
            Recipes = new List<Recipe>();
            Plates = new List<Plate>();
        }

        public List<Recipe> Recipes { get; set; }
        public List<Plate> Plates { get; set; }
    }
}