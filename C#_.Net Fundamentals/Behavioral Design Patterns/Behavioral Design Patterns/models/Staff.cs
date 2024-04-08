using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.models
{
    public class Staff
    {
        public string Name { get; set; }
        public List<string> SubscribedBookTypes { get; set; }

        public Staff(string name, List<string> subscribedBookTypes)
        {
            Name = name;
            SubscribedBookTypes = subscribedBookTypes;
        }
    }
}
