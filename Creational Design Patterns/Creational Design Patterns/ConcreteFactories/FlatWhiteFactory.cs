using Creational_Design_Patterns.Abstract_Products;
using Creational_Design_Patterns.AbstractFactories;
using Creational_Design_Patterns.Concrete_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns.ConcreteFactories
{
    public class FlatWhiteFactory : ICoffeeFactory
    {

        private readonly BlackCoffee _blackCoffee1 = new BlackCoffee();
        private readonly BlackCoffee _blackCoffee2 = new BlackCoffee();
        private readonly IMilk _milk;

        public FlatWhiteFactory(IMilk milk)
        {
            _milk = milk;
        }

        public ICoffee CreateCoffee()
        {
            return new FlatWhite(_blackCoffee1, _blackCoffee2, _milk);
        }
    }
 
}
