using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDesignPatternTesting
{
    class SandwichVegetarian : Sandwich
    {
        public SandwichVegetarian()
        {
            CheeseList = new string[] { "Cheddar", "Gouda" };
        }
        protected override void CutBread()
        {
            Console.WriteLine("Bread has been cut");
        }

        protected override void AddMeat() { }

        protected override void AddCheese()
        {
            Console.WriteLine("Adding cheese:");
            foreach (var cheese in CheeseList)
            {
                Console.WriteLine(cheese);
            }
            Console.WriteLine("Cheese has been added");
        }

        protected override void AddSalad()
        {
            Console.WriteLine("Salad has been added");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Condiments have been added");
        }
    }
}
