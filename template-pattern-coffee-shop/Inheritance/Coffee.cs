using System;
using System.Collections.Generic;
using System.Text;

namespace template_pattern_coffee_shop.Inheritance
{
    public class Coffee : CaffineBeverage
    {
        public override void PrepareReceipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        public void BrewCoffeeGrinds()
        {
            Console.WriteLine("Inheritance:Coffee: Dripping the coffee through the filter");
        }

        public void AddSugarAndMilk()
        {
            Console.WriteLine("Inheritance:Coffee: Adding Sugar and Milk");
        }
    }
}
