using System;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    [Serializable]
    class Tartiflette : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Reblochon(), 1);
            this.Ingredients.Add(new Potato(), 1);
            this.Ingredients.Add(new Bacon(), 5);
        }

        protected override void SetTools()
        {
            
        }
    }
}
