using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    class ChocolateBanana : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Banana(), 1);
            this.Ingredients.Add(new Chocolate(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
