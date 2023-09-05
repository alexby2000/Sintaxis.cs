
/*
    Una clase genérica en C# es una especie de "talla única" para los datos. Se trata de una clase que puede trabajar con varios tipos de datos, 
    sin tener que ser reescrita para cada uno. Las clases genéricas nos permiten definir clases, interfaces y métodos con los llamados "parámetros
    de tipo", que son marcadores de posición para los tipos de datos reales que se usarán.

    Por ejemplo, podrías tener una clase genérica "Lista" que puede manejar listas de enteros, listas de cadenas, listas de objetos de una clase 
    personalizada, y así sucesivamente.  
*/


using System;

namespace ClasesGenericas
{
    /*
       En este ejemplo, hemos creado una clase genérica llamada Caja que puede contener cualquier tipo de datos. 
       El tipo de datos es representado por T, que se utiliza en todo el cuerpo de la clase. Luego, cuando creamos una instancia de Caja,
       podemos especificar el tipo de datos que queremos que contenga.
    */

    public class Caja<T>
    {
        private T contenido;

        public T Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }

        // Método que muestra el contenido de la caja
        public void MostrarContenido()
        {
            Console.WriteLine($"El contenido de la caja es: {contenido}");
        }

        // Programa principal que crea un objeto "Caja" con diferentes tipos de datos
        static void Main(string[] args)
        {
            Caja<string> cajaDePalabras = new Caja<string>();
            cajaDePalabras.Contenido = "Hola, Mundo!";
            cajaDePalabras.MostrarContenido();  // Salida: El contenido de la caja es: Hola, Mundo!

            Caja<int> cajaDeNumeros = new Caja<int>();
            cajaDeNumeros.Contenido = 42;
            cajaDeNumeros.MostrarContenido();  // Salida: El contenido de la caja es: 42
        }
    }




    // CLASES GENÉRICAS CON MÚLTIPLES TIPOS DE DATOS

    public class Partido<Team1, Team2>
    {
        public Team1 Local { get; set; }
        public Team2 Visitante { get; set; }

        public Partido(Team1 local, Team2 visitante)
        {
            Local = local;
            Visitante = visitante;
        }

        public void MostrarPartido()
        {
            Console.WriteLine($"Partido: {Local} VS {Visitante}");
        }


        public static void Main(string[] args)
        {
            Partido<string, string> partidoFutbol = new Partido<string, string>("Barcelona FC", "Real Madrid");
            partidoFutbol.MostrarPartido();  // Salida: Partido: Barcelona FC VS Real Madrid
        }
    }
}