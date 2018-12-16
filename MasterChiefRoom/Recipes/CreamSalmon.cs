using System;
using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    [Serializable]
    class CreamSalmon : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Salmon(), 1);
            this.Ingredients.Add(new CremeFraiche(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
