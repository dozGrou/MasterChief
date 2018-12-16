﻿using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    class NicoiseSalad : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Pasta(), 4);
            this.Ingredients.Add(new Olive(), 10);
            this.Ingredients.Add(new Tuna(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
