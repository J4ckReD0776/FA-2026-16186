using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3
{
    internal class Ejer1
    {
        static void Main(string[] args)
        {
            String n, c;

            Console.WriteLine("Ingresa tu nombre: ");
            n = Console.ReadLine();
            Console.WriteLine("Ingrese Carrera: ");
            c = Console.ReadLine();

            Console.WriteLine("\n--------- IMPRESION CON + --------");
            Console.WriteLine(n+", Bienvenido al cruso FA de la carrera " + c);

            Console.WriteLine("\n--------- IMPRESION CON $ --------");
            Console.WriteLine($"{n}, Bienvenido al cruso FA de la carrera {c}");
            Console.ReadKey();

        }
    }
}
