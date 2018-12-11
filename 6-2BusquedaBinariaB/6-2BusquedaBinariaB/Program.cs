using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2BusquedaBinariaB
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
            int[] CodigoBarras = { 123456, 123457, 123458, 123459, 123460, 123461, 123462, 123463, 123464, 123465 };
            string[] Nombres = { "Jabon", "Cerveza", "Chocomilk", "Ketchup", "Platanos", "Baso", "Galletas", "Huevos", "Queso", "Libro" };
            double[] Precios = { 11, 34, 25, 40, 11, 15, 21, 88, 37, 600 };
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("******************Busqueda Binaria******************"); //Inicio del programa
                    Console.WriteLine("Ingresa el codigo de barras del producto a buscar.(Ingresa -1 para terminar el programa.)");
                    Console.Write("R: ");
                    Valor = Convert.ToInt32(Console.ReadLine()); //Captura del valor a buscar
                    if (Valor == -1) //Si se cumple, el usuario desea salir del programa
                    {
                        Salir = true;
                    }
                    else //Proceso de busqueda
                    {
                        Posicion = P.Funcion(CodigoBarras, Valor); //Se realiza una buqueda la cual retorna la posicion del valor a encontrar
                        if (Posicion == -2) //Cuando se retorna un -2 significa que no se encontro el valor
                        {
                            Console.WriteLine("\nValor no encontrado.");
                        }
                        else //Significa que si se encontro el valor y se despliegan sus datos
                        {
                            Console.WriteLine("\n{0}\t{1}\tPrecio: ${2:#.##}.", CodigoBarras[Posicion], Nombres[Posicion], Precios[Posicion]);
                        }
                    }
                } 
                catch //Captura de excepciones
                {
                    Console.WriteLine("A ocurrido un error.");
                }
                Console.WriteLine("Preciona una tecla para continuar.");
                Console.ReadKey();
            } while (Salir == false); //Do-While que nos permite permanecer en el programa
        }
    }
}
