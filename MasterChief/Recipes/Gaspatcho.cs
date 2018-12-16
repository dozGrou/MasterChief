using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    public class Gaspatcho : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Tomate(), 1);
            this.Ingredients.Add(new Oignon(), 1);
            this.Ingredients.Add(new Concombre(), 1);
            this.Ingredients.Add(new PainRassi(), 1);
            this.Ingredients.Add(new HuileDOlive(), 1);
            this.Ingredients.Add(new Vinaigre(), 1);
            this.Ingredients.Add(new Poivron(), 1);
            this.Ingredients.Add(new Sel(), 1);
            this.Ingredients.Add(new Poivre(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}