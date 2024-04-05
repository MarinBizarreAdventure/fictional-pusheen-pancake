using Behavioral_Design_Patterns.models;
using Behavioral_Design_Patterns;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("John", "john@example.com");
        Staff staff1 = new Staff("Alice", new List<string> { "Fiction"});
        StaffNotification staffNotification = new StaffNotification();

        staffNotification.AddStaff(staff1);

        Book book1 = new Book("Book1", "Fiction");
        Book book2 = new Book("Book2", "Non-fiction");

        OrderProcessor orderProcessor = new OrderProcessor();

        orderProcessor.AddObserver(new EmailNotification());
        orderProcessor.AddObserver(staffNotification);

        // Simulate order placement
        Order order1 = new Order(customer1, book1);
        Order order2 = new Order(customer1, book2);

        orderProcessor.NotifyResponsableStaff(order1);
        orderProcessor.NotifyResponsableStaff(order2);

        // Process orders
        orderProcessor.ProcessOrder(order1);
        orderProcessor.ProcessOrder(order2);


       
        Console.ReadLine();
    }
}