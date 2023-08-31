using System;

namespace For.Loop
{
  class Program
  {
    static void Main(string[] args)
    {
        // Ejemplo 1

      for (int i = 0; i < 5; i++) 
      {
        Console.WriteLine(i);
      }    

      // Ejemplo 2

      for (int i2 = 0; i2 <= 10; i2 = i2 + 2)
      {
        Console.WriteLine(i2);
        }

      // Bucles anidados

      // Outer loop
      for (int h = 1; h <= 2; ++h) 
      {
        Console.WriteLine("Exterior: " + h);  // Executes 2 times
        
        // Inner loop
        for (int j = 1; j <= 3; j++) 
        {
          Console.WriteLine(" Interior: " + j);  // Executes 6 times (2 * 3)
        }  
      }
    }
  } 
}