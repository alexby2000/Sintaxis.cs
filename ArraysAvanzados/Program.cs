using System;

namespace ArraysAvanzados
{
    class program
    {
        static void Filtrado()
        {
            // Filtrado de Arrays

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numerosPares = numeros.Where(n => n % 2 == 0).ToArray();

            Console.WriteLine(numerosPares);

        }

        static void Busqueda()
        {
            // Busqueda de datos en arrays

            string[] fruits = { "manzana", "naranja", "plátano", "uva", "manzana" };
            int index = Array.IndexOf(fruits, "manzana");               // Devuelve el índice de la primera ocurrencia de un elemento en el array
            int lastIndex = Array.LastIndexOf(fruits, "manzana");       // Devuelve el índice de la última ocurrencia de un elemento en el array
            int error = Array.IndexOf(fruits, "pera");                  // Devuelve -1 porque el elemento no existe en el array seleccionado

            Console.WriteLine("Posición de la primera aparición del elemento: " + index);
            Console.WriteLine("Posición de la última aparición del elemento: " + lastIndex);
            Console.WriteLine("Posición del elemento pera: " + error + " (No existe el elemento pera)");

        }

        static void OpMatem()
        {
            // Operaciones de arrays

            int[] numeros2 = { 1, 2, 3, 4, 5 };

            // Suma de todos los miembros del array
            int suma = numeros2.Sum();
            // Producto de todos los elementos de un array
            int producto = numeros2.Aggregate((x, y) => x * y);
            // Promedio de todos los elementos de un array
            double promedio = numeros2.Average();

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Producto: " + producto);
            Console.WriteLine("Promedio: " + promedio);
        }

        static void Conversion()
        {
            // Conversion de un array en una lista

            int[] numeros3 = { 1, 2, 3, 4, 5 };
            List<int> lista = numeros3.ToList();

            Console.WriteLine("LISTA:");    
            foreach (int i in lista)
            {
                Console.WriteLine("Elemento {0}: " + i);
            }

            // Conversion de un array en un diccionario

            string[] nombres = { "Juan", "María", "Pedro", "Lucía" };
            Dictionary<int, string> diccionario = nombres.ToDictionary(x => Array.IndexOf(nombres, x) + 1, x => x);



        }


        static void Main(string[] args)
        {
            Console.WriteLine("FILTRADO DE ARRAYS\n");
            Filtrado();

            Console.WriteLine("\n------------------------------------------");

            Console.WriteLine("BUSQUEDA DE DATOS EN ARRAYS\n");
            Busqueda();

            Console.WriteLine("\n------------------------------------------");

            Console.WriteLine("OPERACIONES MATEMATICAS EN ARRAYS\n");
            OpMatem();

            Console.WriteLine("\n------------------------------------------");

            Console.WriteLine("CONVERSION DE ARRAYS EN LISTA O DICCIONARIO\n");
            Conversion();



        }
    }
}