using System.Collections.Generic;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    public abstract class Recipe
    {
        public int? OrderId = null;
        public Dictionary<Ingredient, int> Ingredients { get; set; }

        protected Recipe()
        {
            Ingredients = new Dictionary<Ingredient, int>();
        }

        protected abstract void CreateIngredients();
    }
}