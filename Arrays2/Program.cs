/*

Crea un programa que solicite al usuario dos arrays de tamaño n y los sume elemento por elemento, 
creando un nuevo array con los resultados. El programa debe mostrar el array resultante en pantalla.

*/

using System;

namespace Arrays2
{
    class program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario que defina la cant. de elementos de los arrays
            Console.WriteLine("Introduce el tamaño de los arrays: ");
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];
            int[] resultado = new int[n];

            // Ingreso de elementos del primer array
            Console.WriteLine("\nIntroduce los elementos del primer array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elemento {0}: ", i + 1);
                array1[i] = int.Parse(Console.ReadLine());
            }

            // Ingreso de elementos del segundo array
            Console.WriteLine("\nIntroduce los elementos del segundo array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elemento {0}: ", i + 1);
                array2[i] = int.Parse(Console.ReadLine());
            }

            // Realizar la suma de los arrays elemento a elemento, y almacenar el resultado 
            for (int i = 0; i < n; i++)
            {
                resultado[i] = array1[i] + array2[i];
            }

            // Recorrer el array resultado y mostrar en pantalla la suma
            Console.WriteLine("\nLa suma de los arrays es: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", resultado[i]);
            }

        }
    }
}