
/*
    Las restricciones en las clases genéricas son como reglas que estableces para tus amigos antes de prestarles tu preciada colección de cómics.
    Estas reglas definen lo que tus amigos pueden y no pueden hacer con tus cómics. De manera similar, las restricciones en las clases genéricas 
    determinan lo que puedes hacer con los tipos de datos que utilizas en tus clases genéricas.

    Puedes aplicar restricciones a los parámetros de tipo en una definición de clase genérica utilizando la palabra clave where. 
    Esto puede ser útil si necesitas invocar métodos o acceder a propiedades en los tipos de datos que utilizas en tu clase genérica que 
    no están disponibles en el tipo object del que todos los tipos en C# derivan de forma predeterminada.
*/

using System;

namespace ClasesGenericas
{
    // EJEMPLO 1

    public class Contenedor<T> where T : class
    {
        private T contenido;

        public T Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }
    }

    // EJEMPLO 2

    public class Comparador<T> where T : IComparable<T>
    {
        public T Valor1 { get; set; }
        public T Valor2 { get; set; }

        public int Comparar()
        {
            return Valor1.CompareTo(Valor2);
        }
    }
}