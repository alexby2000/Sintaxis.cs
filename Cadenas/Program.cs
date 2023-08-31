using System;

namespace Cadenas
{
  class Program
  {
    static void Main(string[] args)
    {
      // Conceptos basicos

      string saludo = "Hello";
      Console.WriteLine(saludo);

      string saludo1 = "Hi.";
      string saludo2 = "Nice to meet you!";
      Console.WriteLine(saludo1); 
      Console.WriteLine(saludo2);

      string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      Console.WriteLine("The length of the txt string is: " + txt.Length);

      string txt1 = "Hello World";
      Console.WriteLine(txt1.ToUpper());
      Console.WriteLine(txt1.ToLower());

      // Concatenacion

      string firstName = "John ";
      string lastName = "Doe";
      string name = firstName + lastName;
      Console.WriteLine(name);

      string firstName1 = "John ";
      string lastName1 = "Doe";
      string name1 = string.Concat(firstName1, lastName1);
      Console.WriteLine(name1);
     
      string a = "10";
      string b = "20";
      string c = a + b;
      Console.WriteLine(c);  // Concatenacion de numeros

      // Interpolacion

      string firstName2 = "John";
      string lastName2 = "Doe";
      string name2 = $"My full name is: {firstName2} {lastName2}";
      Console.WriteLine(name2);

      

     }
  }
}