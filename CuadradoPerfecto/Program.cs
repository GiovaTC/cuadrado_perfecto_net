using System;

namespace CuadradoPerfecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del cuadrado: ");
            int n;

            // Validar que el usuario ingrese un número entero válido
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Por favor, ingrese un número entero positivo: ");
            }

            Console.WriteLine("\nCuadrado perfecto:\n");

            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < n; columna++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}