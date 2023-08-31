using System;

namespace ArraysManipulacion
{
    class program
    {
        // Inicializar una matriz 

        static void matrices()
        {
            int[,] matriz1 = { { 1, 2 }, { 3, 4 } };    // La matriz se inicializa definiendo los valores

            int[,] matriz2 = new int[2, 2];            // La matriz se inicializa usando 2 ciclos anidados
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriz2[i, j] = (i * 2) + j + 1;
                }
            }

            for (int i = 0; i < 2; i++)           // Mostramos en pantalla el valor en cada Fila x Columna
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Valor en [{0}, {1}] = {2}", i, j, matriz2[i, j]);
                }
            }

        }

        static void cambiarTamaño()
        {
            // Aumentar o disminuir el tamaño de un array

            int[] intArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array original de Estrada Web Group:");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }

            Array.Resize(ref intArray, 7);      // Recordar asignar valores a los nuevos elementos luego de redimensionar

            intArray[5] = 6;
            intArray[6] = 7;

            Console.WriteLine("\n\nArray redimensionado de Estrada Web Group:");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
        }

        static void copiarArray()
        {
            // Declaramos dos arrays, el original y el array de destino

            int[] originalArray = new int[5] { 1, 2, 3, 4, 5 };
            int[] newArray = new int[7];

            Array.Copy(originalArray, 0, newArray, 0, originalArray.Length); // Copiamos los elementos del array original al nuevo array

            newArray[5] = 6;        // Agregamos los elementos restantes
            newArray[6] = 7;        // Agregamos los elementos restantes

            foreach (int i in newArray)
            {
                Console.Write(i + " ");
            }

        }

        static void eliminarElementos()
        {
            /* 
               Una forma común es utilizar la función Array.Resize para disminuir el tamaño del array y eliminar el último elemento.
             
               Otra forma de eliminar elementos de un array es utilizando la función Array.Copy para copiar los elementos existentes
               del array en uno nuevo, sin incluir el elemento que se desea eliminar.

               También se puede utilizar la función RemoveAt para eliminar un elemento específico del array, desplazando los elementos
               a la izquierda para llenar el espacio vacío.        
            */


            // Usaremos la forma de Array.Copy para copiar los elementos existentes del array en uno nuevo, sin incluir
            // al elemento que deseamos eliminar.

            int[] array = { 1, 2, 3, 4, 5 };
            int[] newArray = new int[array.Length - 1];
            int index = 3;

            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);

            array = newArray;

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

        static void modificarElementos()
        {
            // Modificar elementos individuales de un array

            int[] numeros = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = numeros[i] * 2;
            }

            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }
        }

        static void indices()
        {
            /* Los índices son utilizados para acceder a los elementos individuales del array y para realizar operaciones en ellos,
               como agregar, eliminar o modificar elementos.
            */

            int[] miArray = new int[] { 1, 2, 3, 4, 5 };
            int primerElemento = miArray[0]; // Accede al primer elemento del array (índice 0)
            int tercerElemento = miArray[2]; // Accede al tercer elemento del array (índice 2)
            int ultimoElemento = miArray[4]; // Accede al último elemento del array (índice 4)

            // Acceder a los elementos de un array utilizando un bucle for

            int[] miArray2 = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < miArray.Length; i++)
            {
                Console.WriteLine(miArray2[i]);
            }

        }

        static void Main(String[] args)
        {
            Console.WriteLine("INICIALIZAR UNA MATRIZ:\n ");
            matrices();

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("REDIMENSIONAR EL TAMAÑO DE UN ARRAY:\n ");
            cambiarTamaño();

            Console.WriteLine("\n--------------------------------------");

            Console.WriteLine("COPIAR UN ARRAY EN OTRO :\n ");
            copiarArray();

            Console.WriteLine("\n--------------------------------------");

            Console.WriteLine("ELIMINAR ELEMENTOS DE UN ARRAY :\n ");
            eliminarElementos();

            Console.WriteLine("\n--------------------------------------");

            Console.WriteLine("MODIFICAR ELEMENTOS DE UN ARRAY :\n ");
            modificarElementos();

            Console.WriteLine("\n--------------------------------------");

            Console.WriteLine("ELEMENTOS DE UN ARRAY USANDO SUS INDICES :\n ");
            indices();

        }
    }
}