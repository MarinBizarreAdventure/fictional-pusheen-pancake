using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Behavioral_Design_Patterns.models;
using System.Threading.Tasks;
using System.Collections;

namespace Behavioral_Design_Patterns
{
    public class StaffNotification: IObserver
    {
        List<Staff> _staff = new List<Staff>();
        
        public void AddStaff(Staff staff)
        {
            _staff.Add(staff);
        }

        public void RemoveStaff(Staff staff)
        {
            if (_staff.Contains(staff)) { 

                Console.WriteLine($"Staff removed: {staff.Name}");
                _staff.Remove(staff);

            }
            else
            {
                Console.WriteLine($"Staff '{staff.Name}' not found.");
            }
        }
        public void Update(Order order)
        {
            foreach (var member in _staff)
            {
                if (member.SubscribedBookTypes.Contains(order.Book.Type))
                {
                    Console.WriteLine($"Staff {member.Name} notified: New order placed for '{order.Book.Title}' by {order.Customer.Name}");
                }
            }
            
        }
    }
}
