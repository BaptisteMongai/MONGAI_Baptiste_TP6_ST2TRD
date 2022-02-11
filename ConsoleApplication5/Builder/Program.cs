using System;
using ConsoleApplication5.Decorator;

namespace ConsoleApplication5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var director1 = new Director(new PizzaComplete());
            director1.BuildPizza();
            var pizza1 = director1.GetPizza();
            
            var director2 = new Director(new PizzaVegan());
            director2.BuildPizza();
            var pizza2 = director2.GetPizza();
            
            var director3 = new Director(new PizzaVege());
            director3.BuildPizza();
            var pizza3 = director3.GetPizza();
            
            var director4 = new Director(new PizzaHamCheese());
            director4.BuildPizza();
            var pizza4 = director4.GetPizza();

            pizza1.Diplay();
            Console.WriteLine();
            pizza2.Diplay();
            Console.WriteLine();
            pizza3.Diplay();
            Console.WriteLine();
            pizza4.Diplay();

            ///////////////////////////////////////////////////////////////////
            Console.WriteLine();
            
            IFood food1 = new Fish();
            CookingDecorator cookingDecorator = new CookingDecorator(food1);
            cookingDecorator = new RareCooking(cookingDecorator);
            Console.WriteLine("Ingredients: " +  cookingDecorator.Ingredients());
            
            IFood food2 = new Meat();
            CookingDecorator cookingDecorator2 = new CookingDecorator(food2);
            cookingDecorator2 = new RawCooking(cookingDecorator2);
            Console.WriteLine("Ingredients: " +  cookingDecorator2.Ingredients());
            
        }
    }
}