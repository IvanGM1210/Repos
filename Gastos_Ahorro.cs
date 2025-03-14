using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gastos_Ahorro
{
    class Program
    {
        static void Main(string[] args)
        {
        
        System.Console.WriteLine("Ingresa tu ahorro");
            double AHORRO = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa el gasto");
               double GASTO = double.Parse(Console.ReadLine());
                 if (AHORRO > GASTO)
            {
                AHORRO = AHORRO - GASTO;
                GASTO = 0;
                    System.Console.WriteLine("Solvente");
            }
            else
            {
                       System.Console.WriteLine("MI BILLETERA ESTA VACIA!");
            }
        }
    }
}


