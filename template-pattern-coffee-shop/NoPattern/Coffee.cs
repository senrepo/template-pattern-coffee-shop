using System;
using System.Collections.Generic;
using System.Text;

namespace template_pattern_coffee_shop.NoPattern
{
    public class Coffee
    {
        public void PrepareReceipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        public void BoilWater()
        {
            Console.WriteLine("NoPattern.Coffee: Boiling the water");
        }

        public void BrewCoffeeGrinds()
        {
            Console.WriteLine("NoPattern.Coffee: Dipping the Coffee through filter");
        }

        public void PourInCup()
        {
            Console.WriteLine("NoPattern.Coffee: Pour into a Cup");
        }

        public void AddSugarAndMilk()
        {
            Console.WriteLine("NoPattern.Coffee: Add Sugar and Milk");
        }
    }
}
