﻿using System;
using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    [Serializable]
    class MusselFries : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Mussel(), 10);
            this.Ingredients.Add(new CremeFraiche(), 1);
            this.Ingredients.Add(new Potato(), 3);
        }

        protected override void SetTools()
        {
            
        }
    }
}
