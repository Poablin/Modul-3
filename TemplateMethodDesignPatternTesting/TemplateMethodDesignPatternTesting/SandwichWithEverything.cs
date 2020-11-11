using System;

namespace TemplateMethodDesignPatternTesting
{
    class SandwichWithEverything : Sandwich
    {
        public SandwichWithEverything()
        {
            MeatList = new string[] { "Beef", "Bacon"};
            CheeseList = new string[] { "Cheddar", "Gouda" };
        }

        protected override void CutBread()
        {
            Console.WriteLine("Bread has been cut");
        }

        protected override void AddMeat()
        {
            Console.WriteLine("Adding meat:");
            foreach (var meat in MeatList)
            {
                Console.WriteLine(meat);
            }

            Console.WriteLine("Meat has been added");
        }

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
