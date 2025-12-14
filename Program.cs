using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenRectengle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input width \t: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Input length \t: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--------Rectangular picture-------");
            drawRec(width, length);
            Console.WriteLine("\n--------Rectangular area----------");
            int area = findArea(width, length);
            Console.WriteLine("Rectangular area is {0}", area);
            Console.ReadKey();
        }
        public static void drawRec(int w, int l)
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        public static int findArea(int w, int l)
        {
            return w * l;
        }
    }
}
