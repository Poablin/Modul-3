using System.Dynamic;

namespace TemplateMethodDesignPatternTesting
{
    public abstract class Sandwich
    {
        protected string[] MeatList { get; set; }
        protected string[] CheeseList { get; set; }
        public virtual void MakeSandwich()
        {
            CutBread();
            AddMeat();
            AddCheese();
            AddSalad();
            AddCondiments();
        }

       protected abstract void CutBread();
       protected abstract void AddMeat();
       protected abstract void AddCheese();
       protected abstract void AddSalad();
       protected abstract void AddCondiments();

    }
}
