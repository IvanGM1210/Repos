using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogramas_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
        
        System.Console.WriteLine("Ingresa la calificacion de tu examen");
                double EXAMEN = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingresa los programas entregados");
                double Pro_Entregados = double.Parse(Console.ReadLine());
         if (EXAMEN >= 70 && Pro_Entregados >= 7)
            {
        System.Console.WriteLine("APROBADO!!!!!!");
            }
         else
            {
        System.Console.WriteLine("REPROBADO </3 :(");
            }
        }
    }
}