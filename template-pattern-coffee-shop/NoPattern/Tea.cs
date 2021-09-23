using System;
using System.Collections.Generic;
using System.Text;

namespace template_pattern_coffee_shop.NoPattern
{
    public class Tea
    {
        public void PrepareReceipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        public void BoilWater()
        {
            Console.WriteLine("NoPattern.Tea: Boiling the water");
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("NoPattern.Tea: Steeping the Tea");
        }

        public void PourInCup()
        {
            Console.WriteLine("NoPattern.Tea: Pour into a Cup");
        }

        public void AddLemon()
        {
            Console.WriteLine("NoPattern.Tea: Add Lemon");
        }
    }
}
