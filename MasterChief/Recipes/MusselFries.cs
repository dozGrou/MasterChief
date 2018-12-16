using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    class MusselFries : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Mussel(), 10);
            this.Ingredients.Add(new CremeFraiche(), 1);
            this.Ingredients.Add(new Potato(), 3);
        }

        protected override void SetTools()
        {
            
        }
    }
}
