using System;
using System.Collections.Generic;
using System.Text;

namespace template_pattern_coffee_shop.Template
{
    public abstract class CaffeineBeverage
    {
        public void PrepareReceipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public void BoilWater()
        {
            Console.WriteLine("Template:CaffeineBeverage: BoilWater");
        }

        public abstract void Brew();

        public void PourInCup()
        {
            Console.WriteLine("Template:CaffeineBeverage: Pour In Cup");
        }

        public abstract void AddCondiments();
    }
}
