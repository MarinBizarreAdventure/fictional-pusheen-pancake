using Creational_Design_Patterns.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns.Concrete_Products
{
    public class Espresso : ICoffee
    {
        private readonly BlackCoffee _blackCoffee;
        
        public Espresso(BlackCoffee blackCoffee)
        {
            _blackCoffee = blackCoffee;
        }
        public void Display()
        {
            Console.WriteLine("Espresso");
            _blackCoffee.Display();
        }
    }
}
