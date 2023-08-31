using System;

namespace ClasesHerencia
{
    public class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public virtual string Sonido() // método virtual
        {
            return "El animal hace un sonido";
        }
    }

    public class Perro : Animal
    {
        public string Raza { get; set; }
        public override string Sonido() // sobrecarga del método virtual
        {
            return "El perro hace guau guau";
        }
    }

    public class Gato : Animal
    {
        public string Color { get; set; }
        public override string Sonido() // sobrecarga del método virtual
        {
            return "El gato hace miau miau";
        }
    }

    // PROGRAMA PRINCIPAL
    class program
    {
        static void Main(string[] args)
        {
            Perro miPerro = new Perro();
            miPerro.Nombre = "Bobby";
            miPerro.Edad = 5;
            miPerro.Raza = "Labrador Retriever";

            Gato miGato = new Gato();
            miGato.Nombre = "Misu";
            miGato.Edad = 3;
            miGato.Color = "Blanco y negro";

            Console.WriteLine("{0} tiene {1} años y {2}", miPerro.Nombre, miPerro.Edad, miPerro.Sonido());
            Console.WriteLine("{0} tiene {1} años y {2}", miGato.Nombre, miGato.Edad, miGato.Sonido());
        }
    }
}