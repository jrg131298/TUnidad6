using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1BusquedaSecuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Salir = false; //Nos permite permanecer en el programa
            int Opcion; //Guarda la opcion del usuario
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("*************************Busqueda Secuencial*************************"); //Menu
                    Console.WriteLine("Ingresa el numero de la opcion que desees");
                    Console.WriteLine("1.- Ejemplo 1");
                    Console.WriteLine("2.- Ejemplo 2");
                    Console.WriteLine("3.- Salir");
                    Console.Write("R: ");
                    Opcion = Convert.ToInt32(Console.ReadLine()); //Captura de la opcion
                    switch (Opcion) //Comparacion de la opcion
                    {
                        case 1:
                            Escuela E = new Escuela(); //Objeto del primer ejemplo
                            E.Inicio(); //Te manda al inicio del primer ejemplo
                            break;
                        case 2:
                            Tiendita T = new Tiendita(); //Objeto del segundo ejemplp
                            T.Inicio(); //Te manda al inicio del segundo ejemplo
                            break;
                        case 3:
                            Salir = true; //Opcion en caso de que el usuario quiera salir del programa
                            break;
                        default:
                            Console.WriteLine("A ocurrido un error."); //En caso de ingresar una opcion diferente a los del menu
                            break;
                    }
                }
                catch //Captura de excepciones
                {
                    Console.WriteLine("A ocurrido un error."); 
                }
                Console.WriteLine("Preciona una tecla para continuar");
                Console.ReadLine();
            } while (Salir == false); //Nos permite permanecer en el programa
        }
    }
}