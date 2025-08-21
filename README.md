# cuadrado_perfecto_net

<img width="2551" height="1079" alt="image" src="https://github.com/user-attachments/assets/a5f60609-0ddb-4ea8-8762-8d6ca0aa9d52" />

# 🎯 Objetivo

Crear un programa en **Visual Studio 2022**, utilizando **C# (Consola)**, que imprima un **cuadrado perfecto** (hecho de caracteres) en la consola.

---

## ✅ Ejemplo del programa (en C#)

Este programa pedirá al usuario el tamaño del cuadrado y lo imprimirá en consola con asteriscos `*`.

---

## 🧾 Código completo

```csharp
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
🛠️ ¿Cómo crear el proyecto en Visual Studio 2022?
Abre Visual Studio 2022.

Selecciona Crear un nuevo proyecto.

Escoge Aplicación de consola (.NET Core o .NET 6/7).

Asigna un nombre, por ejemplo: CuadradoPerfecto.

Reemplaza el contenido de Program.cs con el código de arriba.

Ejecuta el programa con Ctrl + F5.

🧪 Ejemplo de salida
Si el usuario ingresa 4:

markdown
Copiar código
Ingrese el tamaño del cuadrado: 4

Cuadrado perfecto:

* * * * 
* * * * 
* * * * 
* * * * 

Presione cualquier tecla para salir...
