using Creational_Design_Patterns.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns.Decorators
{
    class SugarDecorator : CoffeeDecorator
    {
        private readonly int _amount;

        public SugarDecorator(ICoffee coffee, int amount) : base(coffee)
        {
            _amount = amount;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($" + {_amount} Sugar");
        }
    }
}
