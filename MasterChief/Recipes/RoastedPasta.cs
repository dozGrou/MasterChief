using System;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    [Serializable]
    class RoastedPasta : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Pasta(), 4);
        }

        protected override void SetTools()
        {
            
        }
    }
}
