using System;
using System.Collections.Generic;
using System.Text;

namespace template_pattern_coffee_shop.Inheritance
{
    public class Tea : CaffineBeverage
    {
        public override void PrepareReceipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("Inheritance:Tea: Steeping the tea bag");
        }

        public void AddLemon()
        {
            Console.WriteLine("Inheritance:Tea: Adding Lemon");
        }
    }
}
