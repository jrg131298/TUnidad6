using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _6_3Hash
{
    class Proceso
    {
        public bool Wea(string sSourceData1, string sSourceData2)
        {
            byte[] tmpSource; //Toma temporalmente los Bytes de ambas cadenas de caracteres a comparar
            byte[] tmpHash; //Toma los bytes de la palabra del arreglo
            byte[] tmpNewHash; //Toma los bytes de la palabra que ingreso el usuario
            bool bEqual = false;
            //Creacion de un array de byte con los datos
            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData1);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData2);
            tmpNewHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            if(tmpNewHash.Length == tmpHash.Length) //Esta primer comparacion permite saber si tienen el mismo largo ambas arreglos de bytes, ya que si no se cumple la condicion, significa que no son la misma cadena de caracteres
            {
                int contador = 0; //Contador que permite almacenar la cantidad de bytes repetidos entre ambas palabras
                while (contador < tmpNewHash.Length && (tmpNewHash[contador] == tmpHash[contador])) //Si se cumple, significa que ambos bytes en la posicion "contador" son iguales
                {
                    contador++;
                } 
                if(contador == tmpNewHash.Length) //Cuando se cumple esta condicion, significa que todos los bytes de ambas palabras son iguales
                {
                    bEqual = true;
                }
            }
            return bEqual;
        }
    }
}
