using System.Collections.Generic;
using MasterChiefRoom.Ingredients;
using MasterChiefRoom.Tools;

namespace MasterChiefRoom.Recipes
{
    public abstract class Recipe
    {
        public int? OrderId = null;
        public Dictionary<Ingredient, int> Ingredients { get; set; }
        public List<Tool> Tools { get; set; }

        public static readonly List<Recipe> Recipes = new List<Recipe>
        {
            new AppleIceCream(),
            new BakedApple(),
            new BananaSplit(),
            new CarbonaraPasta(),
            new CesarSalad(),
            new ChocolateBanana(),
            new ChocolateMousse(),
            new ChocolateStrawberry(),
            new CreamCucumber(),
            new CreamSalmon(),
            new ForestChicken(),
            new FruitsSalad(),
            new Gaspatcho(),
            new GoatCheeseToasts(),
            new HardEgg(),
            new IceCreamBalls(),
            new MozzaTomato(),
            new MusselFries(),
            new NicoiseSalad(),
            new OeufsCocotte(),
            new Omelette(),
            new PastaSaladSurimi(),
            new PateDePorc(),
            new RoastedPasta(),
            new SalmonAvocado(),
            new SteakFries(),
            new StrawberryIceCream(),
            new SugarStrawberry(),
            new Tartiflette(),
            new TomatoSoup(),
        };

        protected Recipe()
        {
            Ingredients = new Dictionary<Ingredient, int>();
            Tools = new List<Tool>();
            
            this.CreateIngredients();
            this.SetTools();
        }

        protected abstract void CreateIngredients();
        protected abstract void SetTools();

        protected void SetTools(List<Tool> tools)
        {
            this.Tools = tools;
        }
    }
}