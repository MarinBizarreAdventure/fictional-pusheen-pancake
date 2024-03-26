using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace IRepository
{
    public interface IRepository<T> where T:Entity
    {
        T GetById(int id);
        IList<T> GetAll();
        T Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }

    public class BrandRepository : IRepository<Brand>
    {
        private List<Brand> _brands = new List<Brand>();
        private int _nextId = 1;

        public Brand GetById(int id)
        {
            Brand brand = _brands.FirstOrDefault(b => b.Id == id);
            if (brand == null)
            {
                throw new ArgumentException($"Brand with ID {id} not found", nameof(id));
            }
            return brand;
        }

        public IList<Brand> GetAll()
        {
            return _brands;
        }
        public Brand Add(Brand entity)
        {
            entity.Id = _nextId++;
            _brands.Add(entity);
            return entity;
        }
        public void Update(Brand entity) 
        {
            int index = _brands.FindIndex(b  => b.Id == entity.Id);
            if (index != -1) 
            {
                _brands[index] = entity;
            }
            else 
            {
                throw new ArgumentException("Brand not found in repository");
            }
        }

        public void Delete(int id)
        {
            try
            {
                Brand brandToRemove = GetById(id);
                _brands.Remove(brandToRemove);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error deleting brand repo: {ex.Message}");
                throw;
            }
        }
    }


    public class CustomerRepository : IRepository<Customer> 
    { 
        private List<Customer> _customers = new List<Customer>();
        private int _nextId = 1;  
        public Customer GetById(int id) 
        { 
            return  _customers.FirstOrDefault(c => c.Id == id);
        }

        public IList<Customer> GetAll() 
        {
          return _customers;
        }  

        public Customer Add(Customer entity)
        {
            entity.Id= _nextId++;
            _customers.Add(entity);
            return entity;
        }

        public void Update(Customer entity) 
        {
            int index = _customers.FindIndex(c => c.Id == entity.Id);
            if (index != -1)
            {
                _customers[index] = entity;
            }
            else
            {
                throw new ArgumentException("Customer not found in repository");
            }
        }
        public void Delete(int id)
        {
            Customer customerToRemove = GetById(id);
            if(customerToRemove != null)
            {
               _customers.Remove(customerToRemove);
            }
        }

    }

    public class DealearshipRepository : IRepository<Dealership>
    {
        private List<Dealership> _dealerships = new List<Dealership>();
        private int _nextId = 1;

        public Dealership GetById(int id)
        {
            return _dealerships.FirstOrDefault(d => d.Id == id);
        }

        public IList<Dealership> GetAll() 
        {
            return _dealerships;
        }

        public Dealership Add(Dealership dealership)
        {
            dealership.Id = _nextId++;
            if (string.IsNullOrWhiteSpace(dealership.Name))
            {
                throw new InvalidInputException(dealership.Id, "Dealership name cannot be empty or whitespace");
            }

            if (string.IsNullOrWhiteSpace(dealership.Location))
            {
                throw new InvalidInputException(dealership.Id, "Dealership location cannot be empty or whitespace");
            }
            _dealerships.Add(dealership);
            return dealership;
        }

        public void Update(Dealership entity)
        {
            int index = _dealerships.FindIndex(d => d.Id == entity.Id);
            if(index != -1)
            {
                _dealerships[index] = entity;
            }
            else
            {
                throw new ArgumentException("Dealeship not found in repository");
            }
        }

        public void Delete(int id)
        {
            var dealearshipToRemove = GetById(id);
            if(dealearshipToRemove != null)
            {
                _dealerships.Remove(dealearshipToRemove);
            }
        }
    }
    

    public class InvalidInputException : Exception
    {
        public int Id {  get;}
        public InvalidInputException(int id, string message) : base(message)
        {
            Id = id;

        }
    }


}
