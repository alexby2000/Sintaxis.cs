using System;

namespace ArraysYColecciones
{
    class program
    {
        // ARRAYS MULTIDIMENSIONALES
        static void arrayMult()
        {
            // Definir un array multidimensional y recorrerla con dos bucles anidados

            int[,] myArray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Valor en [{0}, {1}] = {2}", i, j, myArray[i, j]);
                }
            }
        }

        // Arrays de tipo Jagged (es un Array que contiene otros Arrays como elementos, y cada uno de estos Arrays puede tener un tamaño diferente) 

        static void arrayJagged()
        {
            /* Por ejemplo, para declarar e inicializar un Array de tipo jagged de enteros con dos Arrays internos,
               donde el primer Array tiene tres elementos y el segundo Array tiene dos elementos, se utiliza la siguiente sintaxis:
            */

            int[][] miArrayJagged = new int[2][];
            miArrayJagged[0] = new int[3] { 1, 2, 3 };
            miArrayJagged[1] = new int[2] { 4, 5 };

            int elemento = miArrayJagged[0][1]; // acceder al elemento en la 2ºda posición del 1ºer Array interno de un Array de tipo jagged
            Console.WriteLine(elemento);
        }



        // COLECCIONES

        static void Lista()
        {
            // Inicializar una lista y luego agregar elementos

            List<int> miList = new List<int>();

            miList.Add(1);
            miList.Add(2);
            miList.Add(3);

            int elemento = miList[0];    // Acceder a un elemento de la lista
            Console.WriteLine(elemento);
        }

        static void Diccionario()
        {
            // Declarar e inicializar un diccionario donde las claves son de tipo string y los valores son de tipo int

            Dictionary<string, int> miDiccionario = new Dictionary<string, int>();

            miDiccionario.Add("uno", 1);
            miDiccionario.Add("dos", 2);
            miDiccionario.Add("tres", 3);

            int valor = miDiccionario["dos"];
            Console.WriteLine(valor);
        }

        static void Queue()
        {
            // Es una colección que implementa una estructura de cola, donde el primer elemento en entrar es el primer elemento en salir (FIFO)

            // Declarar e inicializar una cola

            Queue<int> miCola = new Queue<int>();

            miCola.Enqueue(1);
            miCola.Enqueue(2);
            miCola.Enqueue(3);

            int primerElemento = miCola.Peek();     // Acceder al primer elemento de una cola
            primerElemento = miCola.Dequeue();     // Eliminar y devolver el primer elemento de una cola
            Console.WriteLine(primerElemento);
        }

        static void Stack()
        {
            // Es una colección que implementa una estructura de pila, donde el último elemento en entrar es el primer elemento en salir (LIFO)

            // Declarar e inicializar una pila

            Stack<int> miPila = new Stack<int>();

            miPila.Push(1);
            miPila.Push(2);
            miPila.Push(3);

            int ultimoElemento = miPila.Peek();     // Acceder al último elemento de una pila
            ultimoElemento = miPila.Pop();          // Eliminar y devolver el último elemento de una pila
            Console.WriteLine(ultimoElemento);
        }

        static void HashSet()
        {
            // Es una colección que no permite duplicados y proporciona operaciones rápidas de búsqueda, inserción y eliminación

            // Declarar e inicializar un conjunto

            HashSet<int> miConjunto = new HashSet<int>();

            miConjunto.Add(1);
            miConjunto.Add(2);
            miConjunto.Add(3);

            bool resultado = miConjunto.Contains(2);        // Verificar si un elemento está en un conjunto
            Console.WriteLine(resultado);

            miConjunto.Remove(2);       // Eliminar el elemento 2 del conjunto

            // Definimos un nuevo conjunto y realizamos la unión entre éste y el conjunto anterior

            HashSet<int> conjunto2 = new HashSet<int>();

            conjunto2.Add(4);
            conjunto2.Add(5);
            conjunto2.Add(6);

            HashSet<int> union = new HashSet<int>(miConjunto);
            union.UnionWith(conjunto2);     // Operación union entre dos conjuntos
            foreach (int i in union)
            {
                Console.Write(i + " ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("EJEMPLO DE ARRAY MULTIDIMENSIONAL:\n");
            arrayMult();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("EJEMPLO DE ARRAY JAGGED:\n");
            arrayJagged();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("EJEMPLO DE LISTA:\n");
            Lista();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("EJEMPLO DE DICCIONARIO:\n");
            Diccionario();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("EJEMPLO DE QUEUE (COLA)\n");
            Queue();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("EJEMPLO DE STACK (PILA)\n");
            Stack();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("EJEMPLO DE HASHSET (CONJUNTO)\n");
            HashSet();


        }
    }
}