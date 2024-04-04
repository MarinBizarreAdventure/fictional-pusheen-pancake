using Creational_Design_Patterns.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns.Concrete_Products
{
    public class FlatWhite : ICoffee
    {
        private readonly BlackCoffee _blackCoffee1;
        private readonly BlackCoffee _blackCoffee2;

        private readonly IMilk _milk;

        public FlatWhite(BlackCoffee blackCoffee1, BlackCoffee blackCoffee2, IMilk milk)
        {
            _blackCoffee1 = blackCoffee1;
            _blackCoffee2 = blackCoffee2;
            _milk = milk;
        }

        public void Display()
        {
            Console.WriteLine("Flat White:");
            _blackCoffee1.Display();
            _blackCoffee2.Display();
            _milk.Display();
        }
    }
}
