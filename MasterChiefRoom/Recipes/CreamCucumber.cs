using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    class CreamCucumber : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Concombre(), 1);
            this.Ingredients.Add(new CremeFraiche(), 1);
            this.Ingredients.Add(new Poivre(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
