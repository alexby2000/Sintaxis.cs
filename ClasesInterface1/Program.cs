using System;

namespace ClasesInterfaces1
{
    // (Recordar que las interfaces no pueden ser utilizadas para crear objetos, y sus métodos no tienen cuerpo)

    // Ejemplo de implementación de una Interface en una clase

    interface IAnimal
    {
        string Name { get; set; }
        void Eat(string food);
    }

    interface IMammal : IAnimal
    {
        void Speak(string sound);
    }

    class Dog : IMammal
    {
        public string Name { get; set; }
        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}");
        }
        public void Speak(string sound)
        {
            Console.WriteLine($"{Name} says {sound}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";
            myDog.Eat("bones"); // logs "Fido is eating bones"
            myDog.Speak("woof"); // logs "Fido says woof"
        }
    }
}