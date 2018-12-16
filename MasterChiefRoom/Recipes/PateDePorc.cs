using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    public class PateDePorc : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Poitrine(), 2);
            this.Ingredients.Add(new Foie(), 1);
            this.Ingredients.Add(new Oeuf(), 12);
            this.Ingredients.Add(new Sel(), 1);
            this.Ingredients.Add(new Poivre(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}