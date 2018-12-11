using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2BusquedaBinariaB
{
    class Proceso
    {
        public Func<int[], int, int> Funcion = (CondigoB, Valor) =>  //Busqueda
        {
            int Inicio = 0; //Primer posicion en el vector
            int Fin = CondigoB.Length - 1; //Ultima posicion del vector
            int Posicion; //Almacenara el valor a retornar
            while (Inicio <= Fin) 
            {
                Posicion = (Inicio + Fin) / 2; //Pretende localizar el valor central del vector
                if (CondigoB[Posicion] == Valor)
                {
                    return Posicion; //Significa que el valor a sido encontrado
                }
                else if (CondigoB[Posicion] < Valor) 
                {
                    Inicio = Posicion + 1;
                }
                else
                {
                    Fin = Posicion - 1;
                }
            }
            return -2; //Significa que no se encontro el valor
        };
    }
}
