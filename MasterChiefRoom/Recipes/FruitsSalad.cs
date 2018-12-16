using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    class FruitsSalad : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Strawberry(), 3);
            this.Ingredients.Add(new Banana(), 1);
            this.Ingredients.Add(new Apple(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
