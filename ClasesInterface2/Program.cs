using System;

namespace ClasesInterface2
{
    // Implementación explícita de una Interfaz en una clase

    interface IAnimal
    {
        void Move();
    }

    interface IBird
    {
        void Move();
    }

    class Animal : IAnimal, IBird
    {
        void IAnimal.Move()
        {
            Console.WriteLine("Animal is moving on land");
        }
        void IBird.Move()
        {
            Console.WriteLine("Bird is flying in the air");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            ((IAnimal)myAnimal).Move(); // logs "Animal is moving on land"
            ((IBird)myAnimal).Move(); // logs "Bird is flying in the air"
        }
    }
}