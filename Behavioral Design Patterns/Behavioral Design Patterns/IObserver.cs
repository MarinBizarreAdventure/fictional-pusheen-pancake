using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns
{
    public interface IObserver
    {
        void Update(Order order);
    }
}
