using System;
using System.Collections.Concurrent;

namespace ClasificaciondeArrays
{
    class program
    {
        /*

        Este método es uno de los más sencillos de implementar, pero no es eficiente para grandes conjuntos de datos. 
        Se basa en la comparación de elementos adyacentes e intercambia los elementos si están en el orden incorrecto.
        Aquí vemos un ejemplo de cómo utilizar el método Bubble Sort para ordenar una lista de nombres de estudiantes en orden alfabético:

        */
        static void BubbleSort()
        {
            string[] estudiantes = { "Ana", "Pedro", "Juan", "Luisa", "Miguel", "Alexis", "Ricardo" };

            //  En cada iteración, comparo cada par de elementos adyacentes y los intercambio si están en el orden incorrecto
            for (int i = 0; i < estudiantes.Length - 1; i++)
            {
                for (int j = 0; j < estudiantes.Length - i - 1; j++)
                {
                    if (estudiantes[j].CompareTo(estudiantes[j + 1]) > 0)
                    {
                        // Intercambiar los elementos
                        string temp = estudiantes[j];
                        estudiantes[j] = estudiantes[j + 1];
                        estudiantes[j + 1] = temp;
                    }
                }
            }

            // Mostrar la lista ordenada
            foreach (string estudiante in estudiantes)
            {
                Console.WriteLine(estudiante);
            }
        }

        /*
        Este método es similar al Bubble Sort en su simplicidad, pero es más eficiente que el Bubble Sort en términos de tiempo de ejecución.
        Insertion Sort ordena el array uno por uno, insertando cada elemento en su posición correcta en el array.
        Una situación en la que podemos utilizar esto es cuando tenemos una lista de eventos en un calendario que queremos ordenar por fecha.
        Aquí está un ejemplo del código para implementar Insertion Sort en una aplicación de gestión de proyectos:
        */

        // VER METODO EN INTERNET



        /*
        Este es un método de clasificación eficiente que se utiliza comúnmente en muchos lenguajes de programación. 
        Quick Sort divide el array en subconjuntos más pequeños y los ordena recursivamente.
        Es una excelente opción para clasificar grandes conjuntos de datos.
        Aquí está un ejemplo para clasificar datos en orden descendente según un parámetro (como el total de ventas):
        */

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivotValue = arr[right];
            int pivotIndex = left;
            for (int i = left; i < right; i++)
            {
                if (arr[i] > pivotValue)
                {
                    Swap(arr, i, pivotIndex);
                    pivotIndex++;
                }
            }
            Swap(arr, pivotIndex, right);
            return pivotIndex;
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /*
        Este método también divide el array en subconjuntos más pequeños, pero en lugar de ordenarlos recursivamente,
        los mezcla para crear un array ordenado.
        Por ejemplo Merge Sort puede ser utilizado para clasificar datos de manera rápida y eficiente.
        Aquí hay un ejemplo para clasificar datos de venta y ordenarlos por producto y luego por fecha de venta.
        */

        // VER METODO EN INTERNET




        static void Main(string[] args)
        {
            Console.WriteLine("METODO DE CLASIFICACION BUBBLE SORT\n");
            BubbleSort();


        }
    }
}