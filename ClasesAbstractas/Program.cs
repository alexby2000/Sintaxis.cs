 /*
   Las clases abstractas actúan como plantillas o modelos para otras clases, proporcionando una estructura y comportamiento básicos
   que las clases derivadas pueden usar y personalizar. Son una forma de definir una clase base que comparte algunas características comunes, 
   pero que requiere que las clases derivadas definan algunos detalles específicos.
  
   A diferencia de las clases regulares, las clases abstractas pueden tener métodos y propiedades abstractas.
   Un método abstracto es un método que no tiene una implementación concreta, sino que sólo define su firma.
   Las clases derivadas deben proporcionar su propia implementación del método abstracto.
 */

using System;

namespace ClasesAbstractas
{
    public abstract class Vehiculo
    {
        public int NumeroRuedas { get; set; }
        public int VelocidadMaxima { get; set; }

        public abstract void Acelerar();
        public abstract void Frenar();
    }

    public class Automovil : Vehiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("El automóvil está acelerando");
        }

        public override void Frenar()
        {
            Console.WriteLine("El automóvil está frenando");
        }
    }
}