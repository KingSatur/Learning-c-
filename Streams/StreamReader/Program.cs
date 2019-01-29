using System.IO;
using System;

namespace Streamreader
{
    class Program
    {
        static void Main(string[] args)
        {

            Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);

            string line;

            //LEER TODO EL ARCHIVO
            /*while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                Console.WriteLine(line);
            }
            */

            /*SEGUNDA FORMA DE LEER EL ARCHIVO
            //fs.Seek(2, SeekOrigin.Begin); Seria como iniciar desde el 3 caracter de la primera linea
            String todo = reader.ReadToEnd();
            Console.WriteLine(todo);
            */

            //Siempre debemos cerrar el flujo de datos
            reader.Close();
            fs.Close();





        }
    }
}
