using System;
using MasterChiefRoom.Ingredients;

namespace MasterChiefRoom.Recipes
{
    [Serializable]
    class MozzaTomato : Recipe
    {
        protected override void CreateIngredients()
        {
            this.Ingredients.Add(new Tomate(), 1);
            this.Ingredients.Add(new Mozzarella(), 1);
        }

        protected override void SetTools()
        {
            
        }
    }
}
