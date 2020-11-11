using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDesignPatternTesting
{
    class SandwichVegetarian : Sandwich
    {
        protected override void CutBread()
        {
            Console.WriteLine("Bread has been cut");
        }

        protected override void AddMeat() { }

        protected override void AddCheese() { }

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
