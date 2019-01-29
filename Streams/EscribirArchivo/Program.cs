using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscribirArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream fs = new FileStream("./escribirArchivo.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine("Hola, TENGO LA VERGA GIGANTE");

            writer.Close();
            fs.Close();


        }
    }
}
