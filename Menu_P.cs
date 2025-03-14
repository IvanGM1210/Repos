using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int op;
            double volumen,
                Masa,
                Densidad;
           
            Console.WriteLine("MENU");
            Console.WriteLine("Ingresa el NUMERO de la operacion que se desea realizar");
            Console.WriteLine(" 1.Area Cuadrado\n 2.Promedio\n 3.Temperatura\n 4.Densidad\n 5.Masa\n 6.Volumen\n 7.Puntaje\n");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                  Console.WriteLine("AREA CUADRADO ");
                     Console.WriteLine("Ingresa el lado del cuadrado");
                      double lado = double.Parse(Console.ReadLine());
                        double Area = lado * lado;
                         Console.WriteLine("El area del cuadrado es: " + Area);
                    break;
                case 2:
                  Console.WriteLine("PROMEDIO");
                     double calif2 = 0,
                              calif;
                                Console.WriteLine("Cuantas materias llevas?");
                                    int no_materias = int.Parse(Console.ReadLine());
                   
                    for (int i = 1; i <= no_materias; i++)
                    {
                     Console.WriteLine("Ingresa la calificacion de tu materia " + i);
                         calif = double.Parse(Console.ReadLine());
                            calif2 = calif2 + calif;
                    }
                             double promedio = calif2 / no_materias;
                   
                    if (promedio >= 6)
                    {
                                 Console.WriteLine("Aprobado");
                    }
                    else
                    {
                                     Console.WriteLine("Reprobado :C");
                    }
                    
                                      Console.WriteLine("Su promedio es: " + promedio);
                    break;
                case 3:
             
                 Console.WriteLine("TEMPERATURA");
                   double temperatura,
                           presion;               
                             Console.WriteLine("Ingrese la Temperatura");
                               temperatura = double.Parse(Console.ReadLine());
                                 Console.WriteLine("Ingrese la Presion");
                                   presion = double.Parse(Console.ReadLine());
                    if (temperatura > 100 || presion > 200)
                    {
                          Console.WriteLine("ALERTA");
                    }
                    else
                    {
                          Console.WriteLine("NORMAL");
                    }
                    break;
                case 4:
                    
                 Console.WriteLine("DENSIDAD"); 
                   Console.WriteLine("Ingrese masa del objeto");
                     Masa = double.Parse(Console.ReadLine());
                      Console.WriteLine("Ingrese el volumen del objeto");
                       volumen = double.Parse(Console.ReadLine());
                        Console.WriteLine("La densidad del objeto es: " + (Masa / volumen));
                    break;
                case 5:
         
                 Console.WriteLine("MASA");
                  Console.WriteLine("Ingresa densidad del objeto");
                    Densidad = double.Parse(Console.ReadLine());
                     Console.WriteLine("Ingrese volumen del objeto");
                      volumen = double.Parse(Console.ReadLine());
                       Console.WriteLine("La masa del objeto es: " + (Densidad * volumen));
                   break;
                case 6:
                    
                 Console.WriteLine("VOLUMEN");
                   Console.WriteLine("Ingresa la masa del objeto");
                     Masa = double.Parse(Console.ReadLine());
                      Console.WriteLine("Ingresa la densidad del objeto");
                       Densidad = double.Parse(Console.ReadLine());
                        Console.WriteLine("El volumen del objeto es: " + (Masa / Densidad));
                    break;
                case 7:
                   
                 Console.WriteLine("PUNTAJE");
                  Console.WriteLine("Ingresa tu puntuacion");
                   double puntuacion = double.Parse(Console.ReadLine());
                    if (puntuacion >= 200)
                    {
                         Console.WriteLine("ALTO");
                    }
                    else
                    {
                            Console.WriteLine("BAJO");
                    }
                    break;
                default:
                  Console.WriteLine("NONE");
                    Console.WriteLine("Opcion no valida");
                      break;

            }
            Console.ReadKey();
        }
    }
}



