using System.Collections.Generic;

namespace ConsoleApplication5
{
    class PizzaComplete : Builder
    {
        public override void addHam()
        {
            pizza.ingredients.Add("Ham");
        }
        public override void addCheese()
        {
            pizza.ingredients.Add("Cheese");
        }
        public override void addVegetable()
        {
            pizza.ingredients.Add("Vegetable");
        }
    }
    
    class PizzaHamCheese : Builder
    {
        public override void addHam()
        {
            pizza.ingredients.Add("Ham");
        }
        public override void addCheese()
        {
            pizza.ingredients.Add("Cheese");
        }
        public override void addVegetable() {}
    }
    
    class PizzaVege : Builder
    {
        public override void addHam() {}
        public override void addCheese()
        {
            pizza.ingredients.Add("Cheese");
        }
        public override void addVegetable()
        {
            pizza.ingredients.Add("Vegetable");
        }
    }
    
    class PizzaVegan : Builder
    {
        public override void addHam() {}
        public override void addCheese() {}
        public override void addVegetable()
        {
            pizza.ingredients.Add("Vegetable");
        }
    }
}