
// EJEMPLO DE POLIMORFISMO UTILIZANDO UNA CLASE BASE

using System;

namespace ClasesPolimorfismo1
{
    public class Animal
    {
        // Definimos un método virtual que imprimirá el sonido del animal
        public virtual void HacerSonido()
        {
            Console.WriteLine("Este animal no hace ningún sonido.");
        }
    }

    // Definimos la clase Perro, que hereda de Animal
    public class Perro : Animal
    {
        // Sobreescribimos el método HacerSonido para que imprima el ladrido del perro
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau guau!");
        }
    }

    // Definimos la clase Gato, que hereda de Animal
    public class Gato : Animal
    {
        // Sobreescribimos el método HacerSonido para que imprima el maullido del gato
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maúlla: ¡Miau miau!");
        }
    }

    // Definimos la clase Pájaro, que hereda de Animal
    public class Pajaro : Animal
    {
        // Sobreescribimos el método HacerSonido para que imprima el canto del pájaro
        public override void HacerSonido()
        {
            Console.WriteLine("El pájaro canta: ¡Pio pio!");
        }
    }

    // Creamos una lista de animales y llamamos al método HacerSonido de cada uno de ellos
    public class Program
    {
        static void Main(string[] args)
        {
            // Creamos una lista de animales
            Animal[] animales = new Animal[3];
            animales[0] = new Perro();
            animales[1] = new Gato();
            animales[2] = new Pajaro();

            // Llamamos al método HacerSonido de cada animal
            foreach (Animal animal in animales)
            {
                animal.HacerSonido();
            }
        }
    }
}