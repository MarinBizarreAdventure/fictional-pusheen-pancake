using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behavioral_Design_Patterns.models;

namespace Behavioral_Design_Patterns
{
    public class Order
    {
        public Customer Customer {  get; set; } 
        public Book Book { get; set; }  
        public string Status { get; set; }

        public Order(Customer customer, Book book) 
        {
            Customer = customer;
            Book = book;
            Status = "Pending";
        }

    }
}
