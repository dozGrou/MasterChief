using System;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    [Serializable]
    class ForestChicken : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Chicken(), 1);
            this.Ingredients.Add(new Potato(), 4);
        }

        protected override void SetTools()
        {
            
        }
    }
}
