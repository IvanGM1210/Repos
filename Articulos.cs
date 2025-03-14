using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Ingrese primer precio");
            double p1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese segundo precio");
            double p2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese tercer precio");
            double p3 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese cuarto precio");
            double p4 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese quinto precio");
            double p5 = double.Parse(Console.ReadLine());
            
            double total = p1 + p2 + p3 + p4 + p5;
            if (total > 1000)
            {
                double desc = total * .10;
                double F_total = total - desc;
                System.Console.WriteLine("El descuento será de: " + desc);
                System.Console.WriteLine("El total sin descuento es: " + total);
                System.Console.WriteLine("Total a pagar final es: " + F_total);
                Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine("Total a pagar es: " + total);
                Console.ReadKey();
            }
        }
    }
}


