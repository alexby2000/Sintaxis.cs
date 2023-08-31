
/*
  Los métodos y propiedades virtuales en C# nos permiten definir un conjunto de comportamientos comunes en una clase base
  y luego personalizarlos en las clases derivadas. Esto nos brinda la flexibilidad de expresar la individualidad de cada clase
  y aprovechar el poder del polimorfismo.  
*/

using System;

namespace MyPvirtual
{
    // METODOS VIRTUALES

    public class Animal
    {
        public virtual void EmitirSonido()
        {
            Console.WriteLine("Hacer ruido");
        }
    }

    public class Perro : Animal
    {
        public override void EmitirSonido()
        {
            Console.WriteLine("Ladrar");
        }
    }

    public class Gato : Animal
    {
        public override void EmitirSonido()
        {
            Console.WriteLine("Maullar");
        }
    }

    // PROPIEDADES VIRTUALES

    public class Puerta
    {
        public virtual string Material { get; set; }
    }

    public class PuertaMadera : Puerta
    {
        public override string Material
        {
            get { return "Madera maciza"; }
        }
    }

    public class PuertaVidrio : Puerta
    {
        public override string Material
        {
            get { return "Vidrio"; }
        }
    }
}