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
            Console.WriteLine("Hello Felix");
            DrawPyramid(5);
        }
        //uhukhuiohihiohiohio
        static void DrawPyramid(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // Draw asterisks 
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); 
            }
        }
    }
}
