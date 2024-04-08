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
    public class RegularMilkFactory: IMilkFactory
    {
        public IMilk CreateMilk()
        {
            return new RegularMilk();
        }
    }
}
