using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreadeFigura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area;
            Console.WriteLine("--- SISTEMA DE CALCULO DE AREAS ---\n");
            Console.WriteLine("1. Calcular area de un cuadrado");
            Console.WriteLine("2. Calcular area de un rectangulo");
            Console.WriteLine("3. Calcular area de un triangulo");
            Console.WriteLine("4. Calcular area de un circulo");
            Console.WriteLine("Ingrese una opcion: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingrese el lado del cuadrado: ");
                    double lado = double.Parse(Console.ReadLine());
                    area = lado * lado;
                    Console.WriteLine($"El area del cuadrado es: {area}");
                    break;
                case 2:
                    Console.WriteLine("Ingrese la base del rectangulo: ");
                    double baseRect = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del rectangulo: ");
                    double alturaRect = double.Parse(Console.ReadLine());
                    area = baseRect * alturaRect;
                    Console.WriteLine($"El area del rectangulo es: {area}");
                    break;
                case 3:
                    Console.WriteLine("Ingrese la base del triangulo: ");
                    double baseTri = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triangulo: ");
                    double alturaTri = double.Parse(Console.ReadLine());
                    area = (baseTri * alturaTri) / 2;
                    Console.WriteLine($"El area del triangulo es: {area}");
                    break;
                case 4:
                    Console.WriteLine("Ingrese el radio del circulo: ");
                    double radio = double.Parse(Console.ReadLine());
                    area = Math.PI * radio * radio;
                    Console.WriteLine($"El area del circulo es: {area}");
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
        }
    }
}
