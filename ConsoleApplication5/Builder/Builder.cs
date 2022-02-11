using System.Collections.Generic;

namespace ConsoleApplication5
{
    public abstract class Builder
    {
        protected Pizza pizza;

        public Pizza GetPizza()
        {
            return pizza;
        }

        public void CreateNewPizza()
        {
            pizza = new Pizza();
            pizza.ingredients = new List<string>() { };
        } 
        
        public abstract void addHam();
        public abstract void addCheese();
        public abstract void addVegetable();
    }
}