using System;
using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    [Serializable]
    class PastaSaladSurimi : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Pasta(), 3);
            this.Ingredients.Add(new Surimi(), 3);
        }

        protected override void SetTools()
        {
            
        }
    }
}
