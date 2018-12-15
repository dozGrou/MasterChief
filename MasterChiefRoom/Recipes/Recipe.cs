using System.Collections.Generic;
using MasterChiefRoom.Ingredients;
using MasterChiefRoom.Tools;

namespace MasterChiefRoom.Recipes
{
    public abstract class Recipe
    {
        public int? OrderId = null;
        public Dictionary<Ingredient, int> Ingredients { get; set; }
        public List<Tool> Tools { get; set; }

        protected Recipe()
        {
            Ingredients = new Dictionary<Ingredient, int>();
            Tools = new List<Tool>();
            
            this.CreateIngredients();
            this.SetTools();
        }

        protected abstract void CreateIngredients();
        protected abstract void SetTools();

        protected void SetTools(List<Tool> tools)
        {
            this.Tools = tools;
        }
    }
}