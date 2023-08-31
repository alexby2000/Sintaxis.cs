using System;

namespace ClasesIntro
{
    /*
    En este ejemplo, la clase Casa tiene dos campos privados: direccion y cantidadHabitaciones.
    Luego, se definen dos propiedades públicas, Direccion y CantidadHabitaciones, para acceder a estos campos desde fuera de la clase.
    Además, se define un constructor que toma dos parámetros: direccion y cantidadHabitaciones, para inicializar los campos de la clase.
    */

    public class Casa
    {
        // Campos privados
        private string direccion;
        private int cantidadHabitaciones;

        // Propiedades públicas
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int CantidadHabitaciones
        {
            get { return cantidadHabitaciones; }
            set { cantidadHabitaciones = value; }
        }

        // Constructor
        public Casa(string direccion, int cantidadHabitaciones)
        {
            this.direccion = direccion;
            this.cantidadHabitaciones = cantidadHabitaciones;
        }
    }

    // MÉTODOS EN UNA CLASE

    /*
     En este ejemplo, hemos creado dos métodos: "EncenderLuces" y "AbrirPuerta". El método "EncenderLuces" no recibe ningún parámetro
     y simplemente escribe un mensaje en la consola indicando que las luces se han encendido en la casa. 
     El método "AbrirPuerta" recibe un parámetro "nombre" que indica el nombre de la persona que está abriendo la puerta, y también
     escribe un mensaje en la consola indicando que la puerta se ha abierto.
    */

    public class Casa2
    {
        public int NumHabitaciones;
        public string Direccion;

        public void EncenderLuces()
        {
            Console.WriteLine("Encendiendo luces en la casa de {0} con {1} habitaciones", Direccion, NumHabitaciones);
        }

        public void AbrirPuerta(string nombre)
        {
            Console.WriteLine("Abriendo la puerta de la casa de {0} para {1}", Direccion, nombre);
        }
    }

    // CONSTRUCTORES EN UNA CLASE

    /*
     En este ejemplo, el constructor toma tres parámetros: habitaciones, tamañoJardin y baños.
     Luego, estos valores se asignan a las propiedades correspondientes de la clase Casa.
    */

    public class Casa3
    {
        public int Habitaciones { get; set; }
        public double TamañoJardin { get; set; }
        public int Baños { get; set; }

        public Casa3(int habitaciones, double tamañoJardin, int baños)
        {
            Habitaciones = habitaciones;
            TamañoJardin = tamañoJardin;
            Baños = baños;
        }
    }
}