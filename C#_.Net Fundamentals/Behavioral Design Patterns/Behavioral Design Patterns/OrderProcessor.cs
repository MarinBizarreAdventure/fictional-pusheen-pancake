using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns
{
    public class OrderProcessor
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer) 
        {
            _observers?.Remove(observer); 
        }

        public void NotifyObservers(Order order)
        {
            foreach (var item in _observers)
            {
                item.Update(order);
            }
        }

        public void ProcessOrder(Order order)
        {
            order.Status = "Processed";
            foreach (var item in _observers)
            {
                if(item is EmailNotification)
                {
                    item.Update(order);
                }
            }
        }

        public void NotifyResponsableStaff(Order order)
        {
            foreach (var item in _observers)
            {
                item.Update(order);
                
            }
        }
    }
}
