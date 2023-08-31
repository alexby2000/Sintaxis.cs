
/*
  Los métodos y propiedades estáticas son aquellos que pertenecen a la clase en sí misma, en lugar de a una instancia de la clase. 
  Esto significa que no es necesario crear un objeto de la clase para poder acceder a ellos, sino que se pueden llamar directamente desde la clase.
*/


using System;

namespace MyPstatic
{
    // METODOS ESTATICOS
    
    // Clase de utilidad de matemáticas
    public static class MathUtils
    {
        public static double SquareRoot(double num)
        {
            return Math.Sqrt(num);
        }

        public static double Logarithm(double num)
        {
            return Math.Log(num);
        }

        public static double AbsoluteValue(double num)
        {
            return Math.Abs(num);
        }
    }

    // Clase de utilidad de cadena
    public static class StringUtils
    {
        public static string ToUpperCase(string str)
        {
            return str.ToUpper();
        }

        public static string ToLowerCase(string str)
        {
            return str.ToLower();
        }

        public static string RemoveSpaces(string str)
        {
            return str.Replace(" ", "");
        }
    }

    // Clase de configuración
    public static class Config
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public static int GetServerPort()
        {
            return int.Parse(ConfigurationManager.AppSettings["ServerPort"]);
        }
    }
}
