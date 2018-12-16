using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    class GoatCheeseToasts : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new GoatCheese(), 1);
            this.Ingredients.Add(new Bread(), 1);
        }

        protected override void SetTools()
        {
        }
    }
}
