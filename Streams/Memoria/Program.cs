using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    class Program
    {
        static void Main(string[] args)
        {

            using(Stream ms = new MemoryStream())
            {
                using (Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read))
                {
                    //TRABAJANDO EN EL DISCO DURO
                    fs.CopyTo(ms);
                }

                ms.Seek(0, SeekOrigin.Begin);

                //TRABAJANDO EN LA MEMORIA

                using(StreamReader reader = new StreamReader(ms))
                {
                    while (!reader.EndOfStream)
                    {
                        Console.WriteLine(reader.ReadLine());
                    }

                }


            }


        }
    }
}
