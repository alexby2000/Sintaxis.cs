
/*
    Las clases genéricas son especialmente útiles cuando trabajamos con colecciones de datos. C# ofrece varias colecciones genéricas incorporadas,
    como List<T>, Dictionary<TKey, TValue>, Queue<T> y Stack<T>.
*/

using System;

namespace ClasesGenericas
{
    public class Tipos
    {
        static void Main(string[] args)
        {
            // LISTA
            // Lista que permite almacenar tantos elementos como quieras, a diferencia de una matriz, que tiene un tamaño fijo.

            List<string> listaNombres = new List<string>();
            listaNombres.Add("Ana");
            listaNombres.Add("Juan");
            listaNombres.Add("Sofía");

            // DICCIONARIO
            // Es una colección de pares clave/valor. Cada clave es única y está asociada a un valor.

            Dictionary<string, int> edades = new Dictionary<string, int>();
            edades.Add("Ana", 25);
            edades.Add("Juan", 32);
            edades.Add("Sofía", 29);

            // QUEUE (es de tipo FIFO)
            // Puedes agregar elementos al final de la cola y quitar elementos desde el principio.

            Queue<string> filaSupermercado = new Queue<string>();
            filaSupermercado.Enqueue("Cliente 1");
            filaSupermercado.Enqueue("Cliente 2");
            filaSupermercado.Enqueue("Cliente 3");

            // Stack (es de tipo LIFO)
            // Puedes agregar elementos a la parte superior de la pila y quitar elementos desde la parte superior.

            Stack<string> pilaLibros = new Stack<string>();
            pilaLibros.Push("Libro 1");
            pilaLibros.Push("Libro 2");
            pilaLibros.Push("Libro 3");
        }
    }
}