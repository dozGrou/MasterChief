using System;
using System.Collections.Generic;
using MasterChiefRoom.Ingredients;
using MasterChiefRoom.Tools;

namespace MasterChiefRoom.Recipes
{
    [Serializable]
    class AppleIceCream : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Apple(), 1);
            this.Ingredients.Add(new IceCream(), 1);
        }

        protected override void SetTools()
        {
            this.SetTools(new List<Tool>
            {
                new Spoon(),
            });
        }
    }
}