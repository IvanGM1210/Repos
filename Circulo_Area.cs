using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo_Area
{
    class Program
    {
        static void Main(string[] args)
        {
        
        System.Console.WriteLine("Ingresa radio del circulo");
            double Rad = double.Parse(Console.ReadLine());
             double A = (Math.Pow(Rad, 2)) * 3.14159;
       
        System.Console.WriteLine("El area del circulo es: " + A);
            Console.ReadKey();
        }
    }
}
