using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and.NET_Basics
{
    public class ShapeCollection<T> : IEnumerable<T>
    {
        private List<T> shapes = new List<T>();

        public void Add(T shape)
        {
            shapes.Add(shape);
        }

        public IEnumerator<T> GetEnumerator() 
        {
            return shapes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() 
        {
            return GetEnumerator();
        }
       

    }
    
}
