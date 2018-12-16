using System;
using MasterChiefRoom.Recipes;

namespace MasterChiefRoom.Models
{
    [Serializable]
    public class Plate
    {
        public Recipe Recipe { get; set; }
        
        public Plate(Recipe recipe)
        {
            Recipe = recipe;
        }
    }
}