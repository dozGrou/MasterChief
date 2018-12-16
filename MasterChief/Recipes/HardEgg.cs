using System;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    [Serializable]
    class HardEgg : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Oeuf(), 3);
        }

        protected override void SetTools()
        {
            
        }
    }
}
