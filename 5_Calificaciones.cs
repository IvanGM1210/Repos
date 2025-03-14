using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Calificaciones_if
{
    namespace _5_Calificaciones
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                                  //CALIFICACIONES//
                 
                System.Console.WriteLine("Ingresa primera calificacion");
                double c1 = double.Parse(Console.ReadLine());
               
                System.Console.WriteLine("Ingresa segunda calificacion");
                double c2 = double.Parse(Console.ReadLine());
               
                System.Console.WriteLine("Ingresa tercera calificacion");
                double c3 = double.Parse(Console.ReadLine());
               
                System.Console.WriteLine("Ingresa cuarta calificacion");
                double c4 = double.Parse(Console.ReadLine());
               
                System.Console.WriteLine("Ingresa quinta calificacion");
                double c5 = double.Parse(Console.ReadLine());
                              
                                 //PROMEDIO//
               
                double prom = (c1 + c2 + c3 + c4 + c5) / 5;
                if (prom >= 6)
                {
                System.Console.WriteLine("Calificacion aprobatoria");
                }
                else
                {
                 System.Console.WriteLine("!Reprobado¡");
                }
                System.Console.WriteLine("Promedio final es: " + prom);
                Console.ReadKey();
            }
        }
    }

        
        }
 
