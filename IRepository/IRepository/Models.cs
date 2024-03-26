using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public abstract class Entity
    {
        public int Id { get; set; }
    }

    public class Brand : Entity
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public List<CarModel> Models { get; set; } = new List<CarModel>();

    }

    public class CarModel : Entity
    {
        public string Name { get; set; }
    }

    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }

    public class Dealership : Entity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Brand> Brands { get; set; } = new List<Brand>();
    }
}
