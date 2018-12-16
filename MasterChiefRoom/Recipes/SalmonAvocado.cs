using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    class SalmonAvocado : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Salmon(), 1);
            this.Ingredients.Add(new Avocado(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
