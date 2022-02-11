namespace ConsoleApplication5.Decorator
{
    public class MediumRareCooking : CookingDecorator
    {
        public MediumRareCooking(IFood food) : base(food) {}

        public override string Ingredients()
        {
            return "medium rare " + base.Ingredients();
        }
    }
}