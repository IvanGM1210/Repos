using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo_Area
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Ingresa altura del triangulo");
               double H = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingresa base del triangulo");
               double B = double.Parse(Console.ReadLine());
        System.Console.WriteLine("El area del triangulo es: " + ((B * H) / 2));
               Console.ReadKey();
        }
    }
}
