using System;

namespace ArraysPOO
{
    // Definimos una clase Tarea para crear un proyecto para administrar una lista de tareas pendientes
    class Tarea
    {
        public string Descripcion { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public bool Completada { get; set; }

    }

    class program
    {
        static void Main(string[] args)
        {
            // Si queremos almacenar una lista de tareas en nuestro proyecto, podemos crear un array que almacene los datos

            Tarea[] tareas = new Tarea[10];

            // Cada elemento del array es un objeto de la clase Tarea. Podemos acceder a cada elemento del array utilizando un índice, por ejemplo:

            tareas[0] = new Tarea { Descripcion = "Hacer la compra", FechaDeVencimiento = DateTime.Today.AddDays(3), Completada = false };
            tareas[1] = new Tarea { Descripcion = "Llamar al médico", FechaDeVencimiento = DateTime.Today.AddDays(5), Completada = false };

            Console.WriteLine("DESCRIPCION: " + tareas[0].Descripcion);

        }
    }
}