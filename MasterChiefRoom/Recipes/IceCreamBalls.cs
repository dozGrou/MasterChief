﻿using System;
using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    [Serializable]
    class IceCreamBalls : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new IceCream(), 3);
        }

        protected override void SetTools()
        {
            
        }
    }
}
