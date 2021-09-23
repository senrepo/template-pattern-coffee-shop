using System;
using System.Collections.Generic;
using System.Text;

namespace template_pattern_coffee_shop.TemplateHook
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void AddCondiments()
        {
            Console.WriteLine("TemplateHook:CoffeeWithHook: Add milk and sugar");
        }

        public override void Brew()
        {
            Console.WriteLine("TemplateHook: Dipping Coffee through filter");
        }

        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("TemplateHook: Would you like to add milk and sugar with your coffee (y/n)?");
            char respone = Console.ReadKey().KeyChar;
            return respone.Equals('y');
        }
    }
}
