using System;

namespace BreakandContinue
{
  class Program
  {
    static void Main(string[] args)
    {
      // Uso del break en for
      
      for (int i = 0; i < 10; i++) 
      {
        if (i == 4) 
        {
          break;
        }
        Console.WriteLine(i);
      }

      // Uso del continue en for

      for (int t = 0; t < 10; t++) 
      {
        if (t == 4) 
        {
          continue;
        }
        Console.WriteLine(t);
      }

      // Uso del break en while

      int s = 0;
      while (s < 10) 
      {
        Console.WriteLine(s);
        s++;
        if (s == 4) 
        {
            break;
        }
      
      }

      // Uso del continue en while

      int w = 0;
      while (w < 10) 
      {
        if (w == 4) 
        {
          w++;
          continue;
        }
        Console.WriteLine(w);
        w++;
      }
     } 
    }
}