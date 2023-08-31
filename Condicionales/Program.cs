using System;

namespace Condicionales
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ejemplo Introductorio

      int myAge = 25;
      int votingAge = 18;

      if(myAge >= votingAge)
      {
        Console.WriteLine("Edad suficiente para votar");
      }
      else
      {
        Console.WriteLine("No cumples la edad para votar");
      }

      // Ejemplo con else if

      int time = 22;
      if (time < 10) 
      {
        Console.WriteLine("Good morning.");
      } 
      else if (time < 20) 
      {
        Console.WriteLine("Good day.");
      } 
      else 
      {
        Console.WriteLine("Good evening.");
      }

      // Short Hand If...else
        
        int time2 = 20;
        string result = (time2 < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);


    
    
    }
  }
}
