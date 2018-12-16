﻿using System;
using MasterChief.Ingredients;

namespace MasterChief.Recipes
{
    [Serializable]
    class CarbonaraPasta : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Bacon(), 1);
            this.Ingredients.Add(new Pasta(), 1);
            this.Ingredients.Add(new CremeFraiche(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
