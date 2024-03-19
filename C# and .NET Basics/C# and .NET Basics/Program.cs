using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C__and.NET_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeCollection<Shape> shapesList = new ShapeCollection<Shape>();

            shapesList.Add(new Rectangle(4, 6, "Rectangle1"));
            shapesList.Add(new Rectangle(5, 5, "Rectangle2"));
            shapesList.Add(new Circle("Circle1", 3));
            shapesList.Add(new Circle("Circle2", 4));
            shapesList.Add(new Rectangle(name:"Rectangle3", side:4));

            foreach (var shape in shapesList)
            {
                shape.Draw();
                if (shape is Rectangle)// could be pattern matching shape is Rectangle rectangle
                {
                    var rectangle = shape as Rectangle;// in that case this is redundant
                    Console.WriteLine($"Area: {rectangle.CalculateArea(scaleFactor:2.0)}");
                }
                else
                {
                    Console.WriteLine($"Area: {shape.CalculateArea()}");
                }
                Console.WriteLine(); 
            }

        }
    }
}
