using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // While loop

      int i = 0;
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
      }

      // Do While loop

      int i2 = 0;
      do 
      {
        Console.WriteLine(i2);
        i2++;
      }
      while (i2 < 5);
    }
  }
}