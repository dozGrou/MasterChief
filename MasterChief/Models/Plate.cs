using System;
using MasterChief.Recipes;

namespace MasterChief.Models
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