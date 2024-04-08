using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IRepository.DealearshipRepository;

namespace IRepository
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class Brand : Entity
    {
       
        public string Country { get; set; }

        public List<CarModel> Models { get; set; } = new List<CarModel>();

    }

    public class CarModel : Entity
    {
        
    }

    public class Customer : Entity
    {
        
        public string Email { get; set; }
        public string Location { get; set; }   

    }

    public delegate IEnumerable<T> GetItemsDealership<T>(Dealership dealership);
    
    public class Dealership : Entity
    {
        public string Location { get; set; }
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Brand> Brands { get; set; } = new List<Brand>();

       
       
    }

    public static class DealershipExtensions
    {
        public static IEnumerable<T> GetItems<T>(this Dealership dealership, GetItemsDealership<T> getItemsDelegate)
        {
            return getItemsDelegate(dealership);
        }
    }
}
