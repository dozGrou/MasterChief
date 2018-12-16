using System;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    [Serializable]
    class ChocolateMousse : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Chocolate(), 1);
            this.Ingredients.Add(new Oeuf(), 1);
            this.Ingredients.Add(new Sugar(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
