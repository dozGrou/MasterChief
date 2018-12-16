using System;
using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    [Serializable]
    class SugarStrawberry : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Sugar(), 1);
            this.Ingredients.Add(new Strawberry(), 5);
        }

        protected override void SetTools()
        {
            
        }
    }
}
