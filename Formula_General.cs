using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_General
{
    class Program
    {
        static void Main(string[] args)
        {
           
        System.Console.WriteLine("Ingresa A");
            double A = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingresa B");
            double B = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingresa C");
            double C = double.Parse(Console.ReadLine());
        
            double x1 = ((-1 * B) + (Math.Sqrt((Math.Pow(B, 2)) - (4 * A * C)))) / (2 * A);
            double x2 = ((-1 * B) - (Math.Sqrt((Math.Pow(B, 2)) - (4 * A * C)))) / (2 * A);
        System.Console.WriteLine("El primer resultado es: " + x1 + "\n" +
                                     "El segundo resultado es: " + x2);
            Console.ReadKey();
        }
    }
}
