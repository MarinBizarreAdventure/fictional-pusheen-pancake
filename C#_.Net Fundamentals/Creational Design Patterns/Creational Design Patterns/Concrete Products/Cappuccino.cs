using Creational_Design_Patterns.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns.Concrete_Products
{
    
    public class Cappuccino : ICoffee
    {
        private readonly BlackCoffee _blackCoffee;
        private readonly IMilk _milk;
        public Cappuccino(BlackCoffee blackCoffee, IMilk milk)
        {
            _blackCoffee = blackCoffee;
            _milk = milk;
        }

        public void Display()
        {
            Console.WriteLine("Cappuccino:");
            _blackCoffee.Display();
            _milk.Display();
        }
    }
}
