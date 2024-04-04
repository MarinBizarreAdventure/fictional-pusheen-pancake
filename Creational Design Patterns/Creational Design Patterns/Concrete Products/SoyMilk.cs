using Creational_Design_Patterns.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns.Concrete_Products
{
    public class SoyMilk : IMilk
    {
        public void Display()
        {
            Console.WriteLine("Soy Milk");
        }
    }
}
