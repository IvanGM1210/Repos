using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_puntuacion
{
    class Program
    {
        static void Main(string[] args)
        {
        
        System.Console.WriteLine("¡Ingresa tu puntuacion!");
                   double P = double.Parse(Console.ReadLine());
            if (P >= 200)
            {
        System.Console.WriteLine("ALTO");
            }
            else
            {
        System.Console.WriteLine("BAJO");
            }
        }
    }
}

