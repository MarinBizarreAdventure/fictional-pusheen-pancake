using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            var brandToyota = new Brand { Name = "Toyota", Country = "Japan" };
            var brandHonda = new Brand { Name = "Honda", Country = "Japan" };
            var brandBMW = new Brand { Name = "BMW", Country = "Germany", Models = new List<CarModel> { new CarModel { Name = "X5" }, new CarModel { Name = "m3" } } };
            var brandFord = new Brand { Name = "Ford", Country = "USA", Models = new List<CarModel> { new CarModel { Name = "Mustang" }, new CarModel { Name = "Fusion" } } };

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
            dealership2.Brands.Add(brandBMW);
            dealership2.Brands.Add(brandToyota);



            // Add customers to dealerships
            dealership1.Customers.Add(new Customer { Name = "John", Email = "john@example.com" });
            dealership1.Customers.Add(new Customer { Name = "Alice", Email = "alice@example.com" });

            dealership2.Customers.Add(new Customer { Name = "Bob", Email = "bob@example.com" , Location = "New York" });
            dealership2.Customers.Add(new Customer { Name = "Emma", Email = "emma@example.com" , Location = "New York" });
            dealership2.Customers.Add(new Customer { Name = "Alice", Email = "alice@example.com", Location = "Las Vegas" });
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

            // Manipulate collection via delegates
            
            Console.WriteLine("Customers:");
            foreach (var customer in dealership1.GetItems(dealership => dealership.Customers))
            {
                Console.WriteLine($"Name: {customer.Name}, Email: {customer.Email}");
            }

            Console.WriteLine("Brands:");
            foreach (var brand in dealership1.GetItems(dealership => dealership.Brands))
            {
                Console.WriteLine($"Name: {brand.Name}");
            }

            dealershipRepository.FindItem(dealership => dealership.Brands.Contains(brandToyota), brandToyota);
            dealershipRepository.FindItem(dealership => dealership.Customers.Any(customer => customer.Name == "Emma"), new Customer { Name = "Emma" });

            // lambda expression
            dealershipRepository.FindItem(
            dealership => dealership.Brands.Contains(brandToyota),
                brandToyota
            );


            // anonymous function
            dealershipRepository.FindItem(delegate(Dealership dealersip){
                return dealersip.Customers.Any(customer => customer.Name == "Emma");
            }, new Customer { Name = "Emma" }
            );



            Console.WriteLine($"- Customers in New York");
            var namesOfCustomersInNewYork = dealership2.Customers
                                                .Where(customer => customer.Location == "New York")
                                                .Select(customer => customer.Name);
            foreach (var name in namesOfCustomersInNewYork)
            {
                Console.WriteLine($"  - {name}");
            }


            Console.WriteLine($"- Brands from Japan at dealeaship1");
            var japanBrands = dealership1.Brands.Where(brand => brand.Country == "Japan");
            foreach (var brand in japanBrands)
            {
                Console.WriteLine($"  - Brand: {brand.Name}, Country: {brand.Country}");
            }

        }
    }
}

