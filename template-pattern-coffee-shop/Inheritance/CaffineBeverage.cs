using System;
using System.Collections.Generic;
using System.Text;

namespace template_pattern_coffee_shop.Inheritance
{
    public abstract class CaffineBeverage
    {
        public abstract void PrepareReceipe();

        public void BoilWater()
        {
            Console.WriteLine("Inheritance:CaffineBeverage: Boil Water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Inheritance:CaffineBeverage: Pour in Cup");
        }

    }
}
