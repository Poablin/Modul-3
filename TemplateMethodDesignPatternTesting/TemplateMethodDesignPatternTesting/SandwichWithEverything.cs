using System;

namespace TemplateMethodDesignPatternTesting
{
    class SandwichWithEverything : Sandwich
    {
        private readonly string[] _meatList = {"Beef","Bacon"};
        private readonly string[] _cheeseList = {"Cheddar", "Gouda"};
        protected override void CutBread()
        {
            Console.WriteLine("Bread has been cut");
        }

        protected override void AddMeat()
        {
            Console.WriteLine("Adding meat:");
            foreach (var meat in _meatList)
            {
                Console.WriteLine(meat);
            }

            Console.WriteLine("Meat has been added");
        }

        protected override void AddCheese()
        {
            Console.WriteLine("Adding cheese:");
            foreach (var cheese in _cheeseList)
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
