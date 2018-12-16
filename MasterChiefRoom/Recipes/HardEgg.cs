using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    class HardEgg : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Oeuf(), 3);
        }

        protected override void SetTools()
        {
            
        }
    }
}
