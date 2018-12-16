using System;
using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    [Serializable]
    class Omelette : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Oeuf(), 3);
            this.Ingredients.Add(new Salad(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
