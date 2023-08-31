using ArraysPOO3;
using System;

namespace ArraysPOO3
{
    // Supongamos que queremos almacenar una lista de personas en nuestra aplicación.
    // Podemos hacerlo utilizando un array escalonado de la siguiente manera:
    class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            return nombre + " (" + edad + ")"; // El método ToString se usa para imprimir el objeto de la clase Persona
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            // Creamos una lista de personas utilizando un array escalonado
            Persona[][] listaDePersonas = new Persona[3][];
            listaDePersonas[0] = new Persona[] { new Persona("Juan", 20), new Persona("Pedro", 25) };
            listaDePersonas[1] = new Persona[] { new Persona("María", 18), new Persona("Lucía", 22), new Persona("Ana", 30) };
            listaDePersonas[2] = new Persona[] { new Persona("José", 35), new Persona("Carlos", 40) };

            // Iteramos sobre la lista de personas utilizando dos ciclos for anidados
            for (int i = 0; i < listaDePersonas.Length; i++)
            {
                Console.Write("Personas en la lista " + i + ": ");
                for (int j = 0; j < listaDePersonas[i].Length; j++)
                {
                    Console.Write(listaDePersonas[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
