using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1;
            double N2;
            double R;
            System.Console.WriteLine("Ingresa el numero de la operacion a realizar");
            System.Console.WriteLine("1.Suma\n 2.Resta\n 3.Multiplicacion\n 4.Division");
            int Op = int.Parse(Console.ReadLine());
        
            switch (Op)
            {
                case 1:
                  //OPERACION SUMA//
             System.Console.WriteLine("SUMA");
                System.Console.WriteLine("Ingrese primer valor para la suma");
                    N1 = double.Parse(Console.ReadLine());
                  System.Console.WriteLine("Ingresa segundo valor para la suma");
                    N2 = double.Parse(Console.ReadLine());
                    R = N1 + N2;
                    System.Console.WriteLine("El resultado de la suma es: " + R);
                    break;
                case 2:
                    //OPERACION RESTA//
             System.Console.WriteLine("RESTA");
                System.Console.WriteLine("Ingresa primer valor para la resta");
                    N1 = double.Parse(Console.ReadLine());
                  System.Console.WriteLine("Ingresa segundo valor para la resta");
                    N2 = double.Parse(Console.ReadLine());
                    R = N1 - N2;
                    System.Console.WriteLine("EL resultado de la resta es: " + R);
                    break;
                case 3:
                    //OPERACION MULTIPLICACION//
                System.Console.WriteLine("MULTIPLICACION");
                  System.Console.WriteLine("Ingresa primer valor para la multiplicacion");
                    N1 = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingresa segundo valor para la multiplicacion");
                    N2 = double.Parse(Console.ReadLine());
                    R = N1 * N2;
                      System.Console.WriteLine("El resultado de la multiplicacion es: " + R);
                    break;
                case 4:
                    //OPERACION DIVISION//
                System.Console.WriteLine("DIVISION");
                  System.Console.WriteLine("Ingresa primer valor para la division");
                    N1 = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingresa segundo valor para la division");
                    N2 = double.Parse(Console.ReadLine());
                    R = N1 / N2;
                      System.Console.WriteLine("El resultado de la division es: " + R);
                    break;
                default:
                    //NONE
                    System.Console.WriteLine("Opcion invalida...");
                    break;
            }
            Console.ReadKey();
        }
    }
}
