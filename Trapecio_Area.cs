using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapecio_Area
{
    class Program
    {
        static void Main(string[] args)
        {
        
        System.Console.WriteLine("Ingrese la base Mayor");
            double BA = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese la base Menor");
            double ba = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese la Altura");
            double H = double.Parse(Console.ReadLine());
       
            double A = ((BA + ba) * H) / 2;
        System.Console.WriteLine("El Area del Trapecio es: " + A);
               Console.ReadKey();
        }
    }
}