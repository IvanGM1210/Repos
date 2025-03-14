using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Precion_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            
        System.Console.WriteLine("Ingresa Temperatura");
            double Tem = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa Presion");
              double Prec = double.Parse(Console.ReadLine());
        if (Prec > 200 || Tem > 100)
            {
                System.Console.WriteLine("ALARMANTE CUIDADO");
            }
        else
            {
                System.Console.WriteLine("SIN PREOCUPACIONES");
            }
        }
    }
}

