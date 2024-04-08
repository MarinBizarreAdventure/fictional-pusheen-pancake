using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.models
{
    public class Book
    {
        public string Title { get; set; }
        public string Type { get; set; }

        public Book(string title, string type)
        {
            Title = title;
            Type = type;
        }

    }
}
