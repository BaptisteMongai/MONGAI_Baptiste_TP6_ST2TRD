namespace ConsoleApplication5.Decorator
{
    public class CookingDecorator : IFood
    {
        protected readonly IFood _food;

        public CookingDecorator(IFood food)
        {
            this._food = food;
        }
        public virtual string Ingredients()
        {
            return this._food.Ingredients();
        }
    }
}