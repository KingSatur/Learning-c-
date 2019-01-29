using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flujo
{
    class Program
    {
        static void Main(string[] args)
        {

            //LEER ARCHIVOS
            //PRIMER PARAMETRO: Nombre del archivo
            //SEGUNDO PARAMETRO: Modo de abrirlo
            //TERCER PARAMETRO: Tipo de acceso, solo lo queremos leer
            Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read);

            //Obtener el numero de bytes
            long quantity = fs.Length;
            Console.WriteLine("El numero de bytes del archivo es de: " + quantity);

           //LEEER USANDO READBYTE()
           /*for(long count = quantity; count > 0; count--)
            {
                fs.Seek(-count, SeekOrigin.End);
                int valor = fs.ReadByte();
                Console.WriteLine("Posicion " + (char)valor);
            }
            */

            //LEER USANDO UN BUCLE
            /*
            int valor = 0;
            while(valor != -1)
            {
                valor = fs.ReadByte();
                if(valor != -1)
                {
                    Console.WriteLine("Posicion " + (char)valor);
                }
            }
            */

            //CERRAR EL STREAM
            fs.Close();



      

        }
    }
}
