using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            var dealershipRepository = new DealershipRepository();

            // Create and add dealerships
            var dealership1 = new Dealership { Name = "Best Cars", Location = "New York" };
            var dealership2 = new Dealership { Name = "Dream Motors", Location = "Los Angeles" };

            dealershipRepository.Add(dealership1);
            dealershipRepository.Add(dealership2);

            // Create brands and car models
            var brandRepository = new BrandRepository();
            var brandToyota = new Brand { Name = "Toyota" };
            var brandHonda = new Brand { Name = "Honda" };
            var brandFord = new Brand { Name = "Ford", Models = new List<CarModel> { new CarModel { Name = "Mustang" }, new CarModel { Name = "Fusion" } } };

            var modelCamry = new CarModel { Name = "Camry" };
            var modelCorolla = new CarModel { Name = "Corolla" };
            var modelCivic = new CarModel { Name = "Civic" };
            var modelAccord = new CarModel { Name = "Accord" };

            // Add car models to brands
            brandToyota.Models.Add(modelCamry);
            brandToyota.Models.Add(modelCorolla);
            brandHonda.Models.Add(modelCivic);
            brandHonda.Models.Add(modelAccord);

            // Add brands to dealerships
            dealership1.Brands.Add(brandToyota);
            dealership1.Brands.Add(brandHonda);
            dealership2.Brands.Add(brandFord);



            // Add customers to dealerships
            dealership1.Customers.Add(new Customer { Name = "John", Email = "john@example.com" });
            dealership1.Customers.Add(new Customer { Name = "Alice", Email = "alice@example.com" });

            dealership2.Customers.Add(new Customer { Name = "Bob", Email = "bob@example.com" });
            dealership2.Customers.Add(new Customer { Name = "Emma", Email = "emma@example.com" });

            // Display dealerships and their details
            Console.WriteLine("Dealerships:");
            foreach (var dealership in dealershipRepository.GetAll())
            {
                Console.WriteLine($"Name: {dealership.Name}, Location: {dealership.Location}");

                Console.WriteLine("Customers:");
                foreach (var customer in dealership.Customers)
                {
                    Console.WriteLine($"- {customer.Name} ({customer.Email})");
                }

                Console.WriteLine("Brands and Models:");
                foreach (var brand in dealership.Brands)
                {
                    Console.WriteLine($"- {brand.Name}");
                    foreach (var model in brand.Models)
                    {
                        Console.WriteLine($"  - {model.Name}");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
