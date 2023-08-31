using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      string x = "Alexis";
      Console.WriteLine(x);

      int y = 25;
      Console.WriteLine(y);

      int z;
      z = 10;
      Console.WriteLine(z);

      int w = 78;
      w = 100;
      Console.WriteLine(w);

      const int b = 50;
      Console.WriteLine(b);


      double p = 47.2D;
      Console.WriteLine(p);

      string name = "Alexis";
      Console.WriteLine("Hola " + name);

      string firstname = "Alexis ";
      string lastname = "Fernandez";
      string fullname = firstname + lastname;
      Console.WriteLine(fullname);

      Console.WriteLine(y + z);

      int a = 1 , c = 2 , d = 3;
      Console.WriteLine(a+c+d);

      int e , f , g;
      e = f = g = 50;
      Console.WriteLine(e+f+g);
      
     }
  }
}
