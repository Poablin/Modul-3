using System;

namespace TemplateMethodDesignPatternTesting
{
    class FactorySandwich
    {
        static void Main(string[] args)
        {
            var sandwich1 = new SandwichWithEverything();
            sandwich1.MakeSandwich();
            Console.WriteLine("\n");
            var sandwich2 = new SandwichVegetarian();
            sandwich2.MakeSandwich();
        }
    }
}
