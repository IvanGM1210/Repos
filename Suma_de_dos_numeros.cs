using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_de_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Ingresa primer numero");
            int N1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingresa segundo numero");
            int N2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("La Suma de los numero: " + (N1 + N2));
        }
    }
}
