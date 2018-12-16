using MasterChief.Ingredients;

namespace MasterChief.Recipes
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
