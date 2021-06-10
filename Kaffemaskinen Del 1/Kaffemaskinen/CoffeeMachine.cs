using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    class CoffeeMachine : Machine
    {
        // Brewing start and stop 
        public override string Start()
        {
            return "Brewing starting..";
        }
        public override string Stop()
        {
            return "Brewmachine shutting down..";
        }

        public string MakeXDrinks(int brewCount)
        {
            return $"Making {brewCount} drinks";
        }
    }
}
