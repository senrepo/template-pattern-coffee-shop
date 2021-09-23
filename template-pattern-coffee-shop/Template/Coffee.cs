using System;
using System.Collections.Generic;
using System.Text;

namespace template_pattern_coffee_shop.Template
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Template:Coffee: Dripping the coffee through the filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Template:Coffee: Adding Sugar and Milk");
        }
    }
}
