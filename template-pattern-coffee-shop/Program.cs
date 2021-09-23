using System;
using template_pattern_coffee_shop;

namespace template_pattern_coffee_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //No pattern
            NoPattern.Coffee coffee = new NoPattern.Coffee();
            NoPattern.Tea tea = new NoPattern.Tea();
            coffee.PrepareReceipe();
            tea.PrepareReceipe();

            //Inhertiance
            //The algorithm is owned by subclass, so if any change in the algorithm, it impacts all sub class, hence this is not a good design
            //the sub class take incharge of algorithm
            Inheritance.Coffee coffee1= new Inheritance.Coffee();
            Inheritance.Tea tea1 = new Inheritance.Tea();
            coffee1.PrepareReceipe();
            tea1.PrepareReceipe();

            //template pattern
            //The algorithm is owned by base class and only implementation variance is handled by sub class.
            //The base class take incharge of algorithm, Base calls approach is "Don't call me, we will call you...."
            Template.Coffee coffee2 = new Template.Coffee();
            Template.Tea tea2 = new Template.Tea();
            coffee2.PrepareReceipe();
            tea2.PrepareReceipe();

            //template pattern with hook
            //Hook method to insert conditions in the algorithm steps
            //the hook methods will be added in the base class as virtual methods and just have retun true
            //whichever subclass needed, then override and provided specific condtions, 
            //This approach will not make any impact in the other subclasses
            TemplateHook.CoffeeWithHook coffee3 = new TemplateHook.CoffeeWithHook();
            TemplateHook.TeaWithHook tea3 = new TemplateHook.TeaWithHook();
            coffee3.PrepareReceipe();
            tea3.PrepareReceipe();


            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
