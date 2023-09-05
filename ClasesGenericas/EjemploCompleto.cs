using System;

namespace ClasesGenericas
{
    // Imagina que tenemos equipos compuestos por jugadores y queremos asegurarnos de que cada jugador tenga un nombre y un número
    // de camiseta. Podemos crear una clase Jugador para almacenar esta información:

    public class Jugador
    {
        public string Nombre { get; set; }
        public int NumeroCamiseta { get; set; }

        public Jugador(string nombre, int numeroCamiseta)
        {
            Nombre = nombre;
            NumeroCamiseta = numeroCamiseta;
        }
    }

    // Ahora, queremos definir una clase Equipo que pueda contener cualquier tipo de jugador.
    // Para eso, utilizaremos una clase genérica:

    public class Equipo<T> where T : Jugador
    {
        private List<T> jugadores = new List<T>();

        public void AgregarJugador(T nuevoJugador)
        {
            jugadores.Add(nuevoJugador);
        }

        public void MostrarJugadores()
        {
            foreach (var jugador in jugadores)
            {
                Console.WriteLine($"Nombre: {jugador.Nombre}, Número de Camiseta: {jugador.NumeroCamiseta}");
            }
        }
    }

    // Finalmente, podemos crear nuestros equipos y añadir jugadores a ellos:

    static void Main(string[] args)
    {
        Equipo<Jugador> equipoFutbol = new Equipo<Jugador>();
        equipoFutbol.AgregarJugador(new Jugador("Lionel Messi", 10));
        equipoFutbol.AgregarJugador(new Jugador("Neymar Jr.", 11));
        equipoFutbol.MostrarJugadores();

        Equipo<Jugador> equipoBasket = new Equipo<Jugador>();
        equipoBasket.AgregarJugador(new Jugador("LeBron James", 23));
        equipoBasket.AgregarJugador(new Jugador("Kevin Durant", 7));
        equipoBasket.MostrarJugadores();
    }
}
