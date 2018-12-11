using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2BusquedaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso P = new Proceso(); //Objeto proceso
            bool Salir = false; //Nos permite permanecer en el programa
            int Valor; //Valor que se trata de buscar
            int Posicion; //Almacena la posicion del valor encontrado
            //Valores
            int[] Control = { 14,23,36,49,53,66,78,84,91,160 };
            string[] Nombres = { "Izaac", "Jesus", "Cecilia", "Dagoberto", "Irma", "Leonor", "Alexis", "Michelle", "Jose", "Luis" };
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("******************Busqueda Binaria******************");
                    Console.WriteLine("Ingresa el numero de control del alumno a buscar.(Ingresa -1 para terminar el programa.)");
                    Console.Write("R: ");
                    Valor = Convert.ToInt32(Console.ReadLine()); //Captura del valor a buscar
                    if(Valor == -1) //Si se cumple, el usuario desea salir del programa
                    {
                        Salir = true;
                    }
                    else //Proceso de busqueda
                    {
                        Posicion = P.Funcion(Control, Valor); //Se realiza una busqueda la cual retorna la posicion del valor a encontrar
                        if(Posicion == -2) //Cuando se retorna un -2 significa que no se encontro el valor
                        {
                            Console.WriteLine("\nValor no encontrado.");
                        }
                        else //Significa que si se encontro el valor y se despliegan sus datos
                        {
                            Console.WriteLine("\nNo. control: {0}\tNombre: {1}.", Control[Posicion], Nombres[Posicion]);
                        }
                    }
                }
                catch //Capturas de excepciones
                {
                    Console.WriteLine("A ocurrido un error.");
                }
                Console.WriteLine("Preciona una tecla para continuar.");
                Console.ReadKey();
            } while (Salir == false); //Do-While que nos permite permanecer en el programa
        }
    }
}
