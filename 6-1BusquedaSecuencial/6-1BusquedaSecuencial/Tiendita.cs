using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1BusquedaSecuencial
{
    class Tiendita
    {
        public List<Objeto2> Listita = new List<Objeto2>(); //Guarda la opcion del usuario
        public void Inicio() 
        {
            bool Salir = false; //Permite permanecer en el ejemplo
            int Opcion; //Captura de la opcion del usuario
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("*************************Busqueda Secuencial*************************"); //Menu
                    Console.WriteLine("Ingresa el numero de la opcion que desees");
                    Console.WriteLine("1.- Dar de alta producto");
                    Console.WriteLine("2.- Buscar producto");
                    Console.WriteLine("3.- Salir");
                    Console.Write("R: ");
                    Opcion = Convert.ToInt32(Console.ReadLine()); //Captura de la opcion del usuario
                    switch (Opcion)
                    {
                        case 1:
                            Alta(); //Te manda a capturar los datos del producto
                            Console.WriteLine("Preciona una tecla para continuar.");
                            Console.ReadLine();
                            break;
                        case 2:
                            Buscar(); //Te manda a buscar un producto por su codigo de barras
                            Console.WriteLine("Preciona una tecla para continuar.");
                            Console.ReadLine();
                            break;
                        case 3:
                            Salir = true; //Nos permite salir del ejemplo
                            break;
                        default: //Caso en que se ingrese una opcion no existente en el menu
                            Console.WriteLine("A ocurrido un error.\nPreciona una tecla para continuar.");
                            Console.ReadLine();
                            break;
                    }
                }
                catch //Captura de excepciones
                {
                    Console.WriteLine("A ocurrido un error.\nPreciona una tecla para continuar.");
                    Console.ReadLine();
                }
            } while (Salir == false); 
        }

        public void Alta() //Proceso donde se almacena un producto
        {
            bool Proceso = false; //Nos permite permanecer en el proceso
            string CodigoBarras, Nombre;  //Datos del producto
            double Precio;                //Datos del producto
            do
            {
                Console.Clear();
                bool Repetir = false, SinValor = false; //Nos permiten identificar valores ya existentes
                try
                {
                    Console.WriteLine("*************************Busqueda Secuencial*************************");
                    Console.WriteLine("Ingresa el codigo de barra del producto: "); //Captura de datos
                    CodigoBarras = Console.ReadLine();
                    SinValor = Nada(CodigoBarras);
                    Repetir = Repetido(CodigoBarras);
                    if (SinValor == false && Repetir == false)
                    {
                        Console.WriteLine("Ingresa el nombre del producto: ");
                        Nombre = Console.ReadLine();
                        SinValor = Nada(Nombre);
                        if (SinValor == false)
                        {
                            Console.WriteLine("Ingresa el precio del producto: ");
                            Precio = Convert.ToDouble(Console.ReadLine());
                            if (Precio > 0)
                            {
                                Objeto2 Valores = new Objeto2(); //Creacion del objeto para almacenar los datos en la lista
                                Valores.CodigoBarras = CodigoBarras;
                                Valores.Nombre = Nombre;
                                Valores.Precio = Precio;
                                Listita.Add(Valores); //Almacenar los datos
                                Proceso = true;
                            }
                            else //En caso de encontrar un error al ingresar los datos
                            {
                                SinValor = true;
                                Repetir = true;
                            }
                        }
                    }
                    else //En caso de un problema al capturar el producto
                    {
                        Console.WriteLine("A ocurrido un error.\nPrecione una tecla para continuar.");
                        Console.ReadKey();
                    }
                }
                catch //Captura de excepciones
                {
                    Console.WriteLine("A ocurrido un error.\nPrecione una tecla para continuar.");
                    Console.ReadKey();
                }
            } while (Proceso == false);  //Nos permite permanecer en el proceso de alta
        }

        public void Buscar() //Metodo que permite realizar una busqueda
        {
            string Wea;
            Console.Clear();
            Console.WriteLine("*************************Busqueda Secuencial*************************");
            Console.WriteLine("Ingresa el codigo de barra del producto: ");
            Wea = Console.ReadLine();
            Existente(Wea); //Metodo el cual se encarga de comparar el valor ingresado por el usuario
        }

        public bool Repetido(string CodigoBarras) //Metodo que permite identificar si cierto dato ya existe en la lista
        {
            foreach (var Item in Listita)
            {
                if (Item.CodigoBarras == CodigoBarras)
                {
                    return true; //En caso de que sea repetido
                }
            }
            return false; //En caso de que no sea repetido
        }

        public bool Nada(string Valor) //Permite identificar si el usuario no ingreso ningun valor
        {
            if (Valor == "")
            {
                return true; //En caso de que este en blanco
            }
            return false; //En caso de que haya texto
        }

        public bool Existente(string CodigoBarras) //Permite buscar datos
        {
            foreach (var Item in Listita)
            {
                if (Item.CodigoBarras == CodigoBarras) //Condicion que al cumplirse, significa que si se encontro el dato
                {
                    Console.WriteLine("{0} {1}: ${2:#.##}.", Item.CodigoBarras, Item.Nombre, Item.Precio);
                    return false;
                }
            }
            Console.WriteLine("Producto no existente."); //En caso de no haberse encontrado concidencia
            return true;
        }
    }
}
