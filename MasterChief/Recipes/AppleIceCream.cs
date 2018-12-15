using System.Collections.Generic;
using MasterChief.Tools;

namespace MasterChief.Recipes
{
    class AppleIceCream : Recipe
    {
//        public override RecipeTypes RecipeTypes => RecipeTypes.Dessert;
        
        protected override void CreateIngredients()
        {
//            this.Ingredients.Add(new Apple(), 1);
//            this.Ingredients.Add(new IceCream(), 1);
        }

        protected override void SetTools()
        {
            this.SetTools(new List<Tool>
            {
                new Spoon(),
            });
        }
    }
}