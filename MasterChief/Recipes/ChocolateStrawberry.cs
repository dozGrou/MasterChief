﻿using System;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    [Serializable]
    class ChocolateStrawberry : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Chocolate(), 1);
            this.Ingredients.Add(new Strawberry(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
