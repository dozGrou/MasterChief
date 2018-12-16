using MasterChiefRoom.Ingredients;
using MasterChiefRoom.Recipes;

namespace MasterChiefRoom.Recipes
{
    class BakedApple : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Apple(), 1);
            this.Ingredients.Add(new Sugar(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
