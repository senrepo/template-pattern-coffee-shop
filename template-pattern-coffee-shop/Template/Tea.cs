﻿using System;
using System.Collections.Generic;
using System.Text;

namespace template_pattern_coffee_shop.Template
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Template:Tea: Steemping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Template:Tea: Adding Lemon");
        }
    }
}
