using Creational_Design_Patterns.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns.AbstractFactories
{
    public interface IMilkFactory
    {
        IMilk CreateMilk();
    }
}
