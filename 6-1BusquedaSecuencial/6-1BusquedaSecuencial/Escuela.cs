using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1BusquedaSecuencial
{
    class Escuela
    {
        public List<Objeto1> Listita = new List<Objeto1>(); //Lugar donde se almacenan los datos
        public void Inicio()
        {
            bool Salir = false; //Nos permite permanecer en el ejemplo 1
            int Opcion; //Guarda la opcion del usuario
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("*************************Busqueda Secuencial*************************"); //Menu
                    Console.WriteLine("Ingresa el numero de la opcion que desees");
                    Console.WriteLine("1.- Dar de alta alumno");
                    Console.WriteLine("2.- Buscar alumno");
                    Console.WriteLine("3.- Salir");
                    Console.Write("R: ");
                    Opcion = Convert.ToInt32(Console.ReadLine()); //Captura de la opcion del usuario
                    switch (Opcion)
                    {
                        case 1:
                            Alta(); //Te manda a capturar los datos del alumno
                            Console.WriteLine("Preciona una tecla para continuar.");
                            Console.ReadLine();
                            break;
                        case 2:
                            Buscar(); //Te manda a buscar un alumno por su numero de control
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

        public void Alta() //Proceso donde se almacena un alumno
        {
            bool Proceso = false; //Nos permite permanecer en el proceso
            int NoControl;                        //Datos del alumno
            string Nombre, ApellidoP, ApellidoM;  //Datos del alumno
            do
            {
                Console.Clear();
                bool Repetir = false, SinValor = false; //Nos permiten identificar valores ya existentes
                try
                {
                    Console.WriteLine("*************************Busqueda Secuencial*************************");
                    Console.WriteLine("Ingresa el numero de control: "); //Captura de datos
                    NoControl = Convert.ToInt32(Console.ReadLine());
                    Repetir = Repetido(NoControl);
                    if(SinValor == false && Repetir == false) 
                    {
                        Console.WriteLine("Ingresa el nombre del alumno: ");
                        Nombre = Console.ReadLine();
                        SinValor = Nada(Nombre);
                        if(SinValor == false)
                        {
                            Console.WriteLine("Ingresa el apellido paterno del alumno: ");
                            ApellidoP = Console.ReadLine();
                            SinValor = Nada(ApellidoP);
                            if (SinValor == false)
                            {
                                Console.WriteLine("Ingresa el apellido materno del alumno: ");
                                ApellidoM = Console.ReadLine();
                                SinValor = Nada(ApellidoM);
                                if (SinValor == false)
                                {
                                    Objeto1 Valores = new Objeto1(); //Creacion del objeto para almacenar los datos en la lista
                                    Valores.NoControl = NoControl;
                                    Valores.Nombre = Nombre;
                                    Valores.ApellidoP = ApellidoP;
                                    Valores.ApellidoM = ApellidoM;
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
                    }
                    else //En caso de un problema al capturar un alumno
                    {
                        Console.WriteLine("Ocurrio un error.\nPrecione una tecla para continuar.");
                        Console.ReadKey();
                    }
                }
                catch //Captura de excepciones
                {
                    Console.WriteLine("A ocurrio un error.\nPrecione una tecla para continuar.");
                    Console.ReadKey();
                }
            } while (Proceso == false); //Nos permite permanecer en el proceso de alta
        }

        public void Buscar() //Metodo que permite realizar una busqueda
        {
            int Wea;
            Console.Clear();
            Console.WriteLine("*************************Busqueda Secuencial*************************");
            Console.WriteLine("Ingresa el numero de control del alumno: ");
            Wea = Convert.ToInt32(Console.ReadLine());
            Existente(Wea); //Metodo el cual se encarga de comparar el valor ingresado por el usuario
        }

        public bool Repetido(int Valor) //Metodo que permite identificar si cierto dato ya existe en la lista
        {
            foreach (var Item in Listita)
            {
                if (Item.NoControl == Valor)
                {
                    return true; //En caso de que sea repetido
                }
            }
            return false; //En caso de que no sea repetido
        }

        public bool Nada(string Valor) //Permite identificar si el usuario no ingreso ningun valor
        {
            if(Valor == "")
            {
                return true; //En caso de que este en blanco
            }
            return false; //En caso de que haya texto
        }

        public bool Existente(int Valor) //Permite buscar datos
        {
            foreach (var Item in Listita)
            {
                if (Item.NoControl == Valor) //Condicion que al cumplirse, significa que si se encontro el dato
                {
                    Console.WriteLine("{0}, {1} {2} {3}.", Item.NoControl, Item.Nombre, Item.ApellidoP, Item.ApellidoM);
                    return false;
                }
            }
            Console.WriteLine("Producto no existente."); //En caso de no haberse encontrado concidencia
            return true;
        }
    }
}
