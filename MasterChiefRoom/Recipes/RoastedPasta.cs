using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    class RoastedPasta : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Pasta(), 4);
        }

        protected override void SetTools()
        {
            
        }
    }
}
