using System;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    [Serializable]
    class StrawberryIceCream : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Strawberry(), 5);
            this.Ingredients.Add(new IceCream(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
