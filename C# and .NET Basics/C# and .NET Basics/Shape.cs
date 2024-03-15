using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C__and.NET_Basics
{
    public abstract class Shape
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        
        public Shape(string name)
        {
            name = name;
        }

        public abstract void Draw();
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        private double radius;

        public double Radius { get { return radius; } set { radius = value;} }


        public Circle(string name, double radius): base(name)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle {Name} with radius {Radius}");
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius*Radius;
        }
    }

    public class Rectangle : Shape
    {
        private double side1;
        private double side2;

        public double Side1 { get { return side1; } set { side1 = value; } }
        public double Side2 { get { return side2; } set { side2 = value; } }

        public Rectangle(double side1, double side2, string name) : base(name)
        {
           Side1 = side1; 
           Side2 = side2;
        }

        public Rectangle(double side, string name): this(side, side, name) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing rectangle {Name} with sides {Side1} and {Side2}");
        }

        public override double CalculateArea()
        {
            return Side2 * Side1;
        }

    }   

}
