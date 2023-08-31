
// EJEMPLO DE POLIMORFISMO UTILIZANDO INTERFACES

using System;

namespace ClasesPolimorfismo2
{
    public interface IHablar
    {
        void HacerSonido();
    }

    public class Perro : IHablar
    {
        public void HacerSonido()
        {
            Console.WriteLine("El perro ladra");
        }
    }

    public class Gato : IHablar
    {
        public void HacerSonido()
        {
            Console.WriteLine("El gato maúlla");
        }
    }


    public class Pajaro : IHablar
    {
        public void HacerSonido()
        {
            Console.WriteLine("El pájaro canta");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<IHablar> animales = new List<IHablar>();
            animales.Add(new Perro());
            animales.Add(new Gato());
            animales.Add(new Pajaro());

            foreach (var animal in animales)
            {
                animal.HacerSonido();
            }
        }
    }
}