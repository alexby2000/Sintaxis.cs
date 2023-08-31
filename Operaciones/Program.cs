using System;

namespace Operaciones
{
    class Program
    {
        static void Main(string[]args)
        {
            // Operador basico
            int x = 100 + 50;
            Console.WriteLine(x);

            int y = x + 200;
            Console.WriteLine(y);
            
            // Operador de asignacion
            double z = 5;
            z /= 3;
            Console.WriteLine(z);

            // Operador de comparacion
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);

            // Operador logico
            Console.WriteLine(x < 200 && x > 100);
            Console.WriteLine(x < 1000 || x > 10);
            Console.WriteLine(!(x < 200 && x > 100));

            // Matematicas
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(9.99));

        }

    }
}
