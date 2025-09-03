using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TallerCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir mensaje
            Console.WriteLine("Bienvenido a C#");

            //-- Definir Variables --
            int a, b, producto;

            //-- Entrada Datos --
            Console.WriteLine("Ingrese Primer Numero:");
            //Guardar valor de la consola
            a= int.Parse(Console.ReadLine());
            //a = int.TryParse(Console.ReadLine()); //Boolean True o False

            Console.WriteLine("Ingrese Segundo Numero:");
            //Guardar valor de la consola
            b = Convert.ToInt32(Console.ReadLine());
            //b = int.TryParse(Console.ReadLine()); //Boolean True o False

            //-- Proceso --
            producto = a * b;

            //-- Salida Datos --
            Console.WriteLine("EL producto es: " + producto);
            Console.WriteLine($"El producto de {a} * {b} = {producto}");

            Console.WriteLine(); //Salto de linea
            Console.WriteLine("Algoritmo Area Triangulo");

            Ejercicio1 ej1 = new Ejercicio1();
            ej1.areatriangulo();

            //Detener pantalla para mostrar el resultado
            Console.ReadKey();
        }
    }
}
