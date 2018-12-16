using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    class SteakFries : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Steak(), 1);
            this.Ingredients.Add(new Potato(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
