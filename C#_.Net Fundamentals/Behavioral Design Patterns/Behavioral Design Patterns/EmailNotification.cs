using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns
{
    public class EmailNotification : IObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"Email sent to {order.Customer.Email}: Your order status for '{order.Book.Title}' is {order.Status}");
        }
    }
}
