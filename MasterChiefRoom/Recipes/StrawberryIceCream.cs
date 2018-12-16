using System;
using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
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
