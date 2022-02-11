namespace ConsoleApplication5
{
    public class Director
    {
        private readonly Builder builder;

        public Director(Builder builder) {
            this.builder = builder;
        }

        public void BuildPizza()
        {
            builder.CreateNewPizza();
            builder.addCheese();
            builder.addHam();
            builder.addVegetable();
        }

        public Pizza GetPizza()
        {
            return builder.GetPizza();
        }
    }
}