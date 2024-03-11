using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DrawPyramid(5);
        }

        static void DrawPyramid(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // Draw asterisks popo
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); 
            }
        }
    }
}
