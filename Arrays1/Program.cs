/* 

Crea un programa que solicite al usuario un número entero n y luego cree un array de tamaño n con valores
aleatorios entre 1 y 100. El programa debe mostrar el array en pantalla y luego ordenarlo de forma ascendente o descendente,
según la elección del usuario.

*/

using System;

namespace Arrays1
{
    class program
    {
        static void Main(string[] args)
        {
            // Ingreso de valores del usuario
            Console.WriteLine("Ingrese el tamaño del array: ");
            int n = int.Parse(Console.ReadLine());

            // Creación del array con n elementos random entre 1 y 101
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            // Muestra en pantalla n valores generados aleatoriamente
            Console.WriteLine("\nArray original: ");
            foreach (int num in array)
            {
                Console.WriteLine(num + " ");
            }

            // Ordena el array de forma ascendente o descendente según elección del usuario
            Console.WriteLine("\n¿Cómo desea ordenar el array? Ascendente / Descendente: ");
            string orden = Console.ReadLine();

            if (orden == "ascendente")
            {
                Array.Sort(array);
            }
            else if (orden == "descendente")
            {
                Array.Sort(array);
                Array.Reverse(array);
            }
            else
            {
                Console.WriteLine("OPCIÓN DE ORDENAMIENTO INVÁLIDA. REINICIE EL PROGRAMA ");
                return;
            }

            // Mensaje final con array ordenado según elección del usuario
            Console.WriteLine("\nArray ordenado " + orden);

            foreach (int num2 in array)
            {
                Console.WriteLine(num2 + " ");
            }
        }
    }
}