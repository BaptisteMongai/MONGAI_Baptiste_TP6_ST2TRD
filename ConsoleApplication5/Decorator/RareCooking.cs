namespace ConsoleApplication5.Decorator
{
    public class RareCooking : CookingDecorator
    {
        public RareCooking(IFood food) : base(food) {}
        public override string Ingredients()
        {
            return "rare " + base.Ingredients();
        }
    }
}