﻿using System;
using System.Collections.Generic;
using MasterChief.Ingredients;
using MasterChief.Tools;

namespace MasterChief.Recipes
{
    [Serializable]
    class AppleIceCream : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Apple(), 1);
            this.Ingredients.Add(new IceCream(), 1);
        }

        protected override void SetTools()
        {
            this.Tools.Add(new Spoon());
        }
    }
}