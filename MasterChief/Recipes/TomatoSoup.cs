using System;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    [Serializable]
    class TomatoSoup : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Tomate(), 10);
            this.Ingredients.Add(new Sel(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
