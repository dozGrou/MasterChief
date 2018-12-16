using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    class Tartiflette : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Reblochon(), 1);
            this.Ingredients.Add(new Potato(), 1);
            this.Ingredients.Add(new Bacon(), 5);
        }

        protected override void SetTools()
        {
            
        }
    }
}
