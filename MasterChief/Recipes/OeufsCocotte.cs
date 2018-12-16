using System;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    [Serializable]
    public class OeufsCocotte : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Oeuf(), 1);
            this.Ingredients.Add(new GruyereRape(), 1);
            this.Ingredients.Add(new Sel(), 1);
            this.Ingredients.Add(new CremeFraiche(), 1);
            this.Ingredients.Add(new Poivre(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}