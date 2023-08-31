/*

Crea un programa que solicite al usuario un array de tamaño n y un número entero k.
El programa debe devolver un nuevo array con los k elementos mayores del array original.

*/

using System;
using System.Reflection.Metadata.Ecma335;

namespace Arrays3
{
    class program
    {
        static void Main(string[] args)
        {
            // Ingreso de valores del usuario
            Console.WriteLine("Ingrese el tamaño del array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] resultado = new int[n];

            // Ingreso de elementos del array
            Console.WriteLine("\nIntroduce los " + n + " elementos del array:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elemento {0}: ", i + 1);
                array1[i] = int.Parse(Console.ReadLine());
            }

            // Ingreso del parámetro k
            Console.WriteLine("\nIngrese el valor de k");
            int k = int.Parse(Console.ReadLine());
            while (k > n)
            {
                Console.WriteLine("\nk debe ser menor que el tamaño del array. Por favor vuelva a ingresar el valor de k:");
                k = int.Parse(Console.ReadLine());
            }

            // Ordeno el array de mayor a menor
            Array.Sort(array1);
            Array.Reverse(array1);

            // Recorro el array ordenado descendente hasta obtener k valores
            Console.WriteLine("\nNuevo array con los " + k + " elementos mayores del array original: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", array1[i]);
            }



        }
    }
}
