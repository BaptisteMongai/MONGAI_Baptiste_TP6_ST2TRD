namespace ConsoleApplication5.Decorator
{
    public class RawCooking : CookingDecorator
    {
        public RawCooking(IFood food) : base(food) {}

        public override string Ingredients()
        {
            return "raw " + base.Ingredients();
        }
    }
}