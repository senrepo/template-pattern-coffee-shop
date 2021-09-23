using System;
using System.Collections.Generic;
using System.Text;

namespace template_pattern_coffee_shop.TemplateHook
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareReceipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if(CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public void BoilWater()
        {
            Console.WriteLine("TemplateHook:CaffeineBeverage: BoilWater");
        }

        public abstract void Brew();

        public void PourInCup()
        {
            Console.WriteLine("TemplateHook:CaffeineBeverage: Pour In Cup");
        }

        public abstract void AddCondiments();

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
