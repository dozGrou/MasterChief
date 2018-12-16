using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    class CesarSalad : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Salad(), 1);
            this.Ingredients.Add(new Chicken(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
