using System;
using System.Collections.Generic;

namespace ConsoleApplication5
{
    public class Pizza
    {
        public List<string> ingredients { get; set; }

        public void Diplay()
        {
            Console.WriteLine("Ingredients:");
            foreach (var item in ingredients)  
            {  
                Console.WriteLine(" {0}", item);  
            } 
        }
        /*
        public override string ToString()
        {
            return ;
        }  */
    }
}