using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.traducir;

namespace TR
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            String palabra;
            String seguir;

            while (!salir)
            {
                Console.WriteLine("Introduce una palabra para traducir a Kakchiquel: ");
                palabra = Console.ReadLine();

                traduction(palabra);

                Console.WriteLine("\nSeguir traduciendo???  s/n");
                seguir = Console.ReadLine();
                salir = seguir.Equals("s") ? false : true;
            }

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }

        public static void traduction(string palabra)
        {
            Traductorio traduce = new Traductorio();
            string msjError = traduce.noEncontrado.ToString();

            traduce.Entrada = palabra;
            var respuesta = traduce.Traducir();

            //Console.WriteLine(respuesta);
            //if (respuesta.Equals(msjError)) { 
                Console.WriteLine($"{palabra} traducido a Kakchikel es: {respuesta}");
            //}
            //else { 
            //    Console.WriteLine("Palabra no encontrada");
            //}

        }
    }
}
