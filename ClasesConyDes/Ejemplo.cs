using System;

namespace ClasesConyDes
{
    // EJEMPLO COMPLETO DE CONSTRUCTORES Y DESTRUCTORES

    public class Coche
    {
        public string modelo;

        // Constructor
        public Coche(string modelo)
        {
            this.modelo = modelo;
            Console.WriteLine($"El coche {modelo} está encendido.");
        }

        // Destructor
        ~Coche()
        {
            Console.WriteLine($"El coche {modelo} está apagado.");
        }


        public static void Main(string[] args)
        {
            Coche miCoche = new Coche("Tesla Model S");
            // El constructor se llama aquí, y verás "El coche Tesla Model S está encendido." en la consola

            // ...Hacer algo con el objeto 'miCoche'...

        } // Aquí, al final del método Main, el objeto 'miCoche' sale del ámbito y el recolector de basura de .NET puede decidir
          // destruirlo en cualquier momento.
    }
}