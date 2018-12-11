using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3Hash
{
    class Program
    {
        //https://support.microsoft.com/es-mx/help/307020/how-to-compute-and-compare-hash-values-by-using-visual-c
        //Link de apoyo
        static void Main(string[] args)
        {
            bool Salir = false; //Valor que nos permite seguir en el programa
            do
            {
                Proceso p = new Proceso(); //Objeto
                string[] valores = { "Jesus", "Juan", "Betzy", "Ricardo", "Leopoldo" }; //Valores los cuales se compararan con la cadena que ingrese el usuario
                bool seArma = false; //Valor que permite saber si se desea otra busqueda
                Console.Clear();
                Console.WriteLine("++++++++++++++++++++++Hash++++++++++++++++++++++");
                Console.Write("Ingresa la palabra a buscar: ");
                string palabra = Console.ReadLine(); //Ingreso del valor el cual se pretende buscar en el vector
                foreach (var value in valores) //Permite realizar la comparacion por metodo Hash de cada valor que existe en el arreglo
                {
                    seArma = p.Wea(value, palabra); //El metodo "Wea" realiza la comparacion por metodo Hash y retorna un valor bool el cual permite saber si se encuentra la palabra en el arreglo
                    if (seArma == true) //Si se cumple, significa que se a encontrado el valor
                    {
                        Console.WriteLine("El valor {0} se encuentra entre los valores.", palabra);
                        break;
                    }
                }

                if (seArma == false) //Si se cumple, significa que no se a encontrado el valor
                {
                    Console.WriteLine("El valor {0} no se encuentra entre los valores.", palabra);
                }
                Console.WriteLine("\nPrecione una tecla para continuar.");
                Console.ReadKey();
                bool SalirProceso = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Deseas realizar otra busqueda: "); //Menu que permite realizar otra busqueda
                    Console.WriteLine("1.- SI");
                    Console.WriteLine("2.- NO");
                    palabra = Console.ReadLine();
                    if(palabra == "1")
                    {
                        SalirProceso = true;
                        Salir = false;
                    }
                    else if(palabra == "2")
                    {
                        SalirProceso = true;
                        Salir = true;
                    }
                } while (SalirProceso == false); //Do-While que nos hace permanecer en el menu
            } while (Salir == false); //Do-While que nos permite seguir en el programa
        }
    }
}
