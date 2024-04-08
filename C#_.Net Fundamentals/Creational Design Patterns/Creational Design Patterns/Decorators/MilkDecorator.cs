using Creational_Design_Patterns.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns.Decorators
{
    class MilkDecorator : CoffeeDecorator
    {
        private readonly IMilk _milk;

        public MilkDecorator(ICoffee coffee, IMilk milk) : base(coffee)
        {
            _milk = milk;
        }

        public override void Display()
        {
            base.Display();
            Console.Write($" + ");
            _milk.Display();
        }
    }
}
