using System;

namespace ArraysPOO2
{
    // Supongamos que queremos implementar una clase llamada Alumno que tenga un array de calificaciones como uno de sus atributos.
    // Podemos hacer lo siguiente:
    class Alumno
    {
        private string nombre;
        private int[] calificaciones;

        public Alumno(string nombre, int[] calificaciones)
        {
            this.nombre = nombre;
            this.calificaciones = calificaciones;
        }

        public void imprimirCalificaciones()
        {
            Console.WriteLine("Calificaciones de " + nombre + ":");
            foreach (int calificacion in calificaciones)
            {
                Console.Write(calificacion + " ");
            }
            Console.WriteLine();
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            int[] calificacionesJuan = new int[] { 8, 9, 10 };
            Alumno juan = new Alumno("Juan", calificacionesJuan);
            juan.imprimirCalificaciones();

            int[] calificacionesMaria = new int[] { 7, 6, 5 };
            Alumno maria = new Alumno("María", calificacionesMaria);
            maria.imprimirCalificaciones();
        }
    }
}