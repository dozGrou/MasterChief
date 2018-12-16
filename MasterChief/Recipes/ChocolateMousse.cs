using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    class ChocolateMousse : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Chocolate(), 1);
            this.Ingredients.Add(new Oeuf(), 1);
            this.Ingredients.Add(new Sugar(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
