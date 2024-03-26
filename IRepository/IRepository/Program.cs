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


            #if DEBUG
                Console.WriteLine("Debug mode is enabled.");
            #else
                Console.WriteLine("Debug mode is disabled.");
            #endif

            var dealershipRepository = new DealearshipRepository();
            // Create and add dealerships
            var dealership1 = new Dealership { Name = "Best Cars", Location = "New York" };
            var dealership2 = new Dealership { Name = "Dream Motors", Location = "Los Angeles" };

            try
            {
                dealershipRepository.Add(dealership1);
                dealershipRepository.Add(dealership2);
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine($"Error: {ex.Message} DealearshipId: {ex.Id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("Cleanup code executed.");
            }
            

            

            // Create brands and car models
            var brandRepository = new BrandRepository();
            var brandToyota = new Brand { Name = "Toyota" };
            var brandHonda = new Brand { Name = "Honda" };
            var brandFord = new Brand { Name = "Ford", Models = new List<CarModel> { new CarModel { Name = "Mustang" }, new CarModel { Name = "Fusion" } } };

            var modelCamry = new CarModel { Name = "Camry" };
            var modelCorolla = new CarModel { Name = "Corolla" };
            var modelCivic = new CarModel { Name = "Civic" };
            var modelAccord = new CarModel { Name = "Accord" };
            try
            {
                brandRepository.Delete(100); // Assuming brand with ID 100 doesn't exist
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error deleting brand main: {ex.Message}");
            }

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
