using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine cm = new CoffeeMachine();
            IngredientContainer ingContainer = new IngredientContainer();
            LiquidContainer liqContainer = new LiquidContainer();

            Console.WriteLine(cm.Start());
            Thread.Sleep(2000);
            Console.WriteLine("How many cups do you wish to brew?");
            int brewCount = int.Parse(Console.ReadLine());
            Thread.Sleep(2000);
            Console.WriteLine(ingContainer.FillIngredients(IngredientContainer.ingredients.coffee));
            Thread.Sleep(4000);
            Console.WriteLine(liqContainer.PourLiquid(LiquidContainer.liquids.water));
            Console.WriteLine(cm.MakeXDrinks(brewCount));
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine(cm.Stop());
            Console.Read();
        }
     }
}
