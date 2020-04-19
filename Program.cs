using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escribirarchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreArchivo = "", ubicacion = "", cadena = "";
            byte[] buffer = new byte[50];

            Console.Write("Escriba el nombre del archivo que desea abrir: ");
            nombreArchivo = Console.ReadLine();

            Console.Write("Escriba la ubicacion donde esta el archivo: ");
            ubicacion = Console.ReadLine();

            // Creacion de archivo

            FileStream archivo = new FileStream(ubicacion + "\\" + nombreArchivo + ".txt", FileMode.Append);

          
            // Llenando el archivo con texto
            Console.WriteLine("Escriba texto en el archivo:");
                    
            cadena = Console.ReadLine();

            archivo.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);

           
            archivo.Close();

            Console.ReadKey();
        }
    }
}
