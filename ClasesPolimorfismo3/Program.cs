
// EJEMPLO DE POLIMORFISMO UTILIZANDO SOBRECARGA DE OPERADORES

using System;

namespace ClasesPolimorfismo3
{
    public abstract class Forma
    {
        public abstract double CalcularArea();
    }

    public class Cuadrado : Forma
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public static Cuadrado operator *(Cuadrado cuadrado, double factor)
        {
            cuadrado.Lado *= factor;
            return cuadrado;
        }
    }

    public class Rectangulo : Forma
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public override double CalcularArea()
        {
            return Lado1 * Lado2;
        }

        public static Rectangulo operator *(Rectangulo rectangulo, double factor)
        {
            rectangulo.Lado1 *= factor;
            rectangulo.Lado2 *= factor;
            return rectangulo;
        }
    }

    public class Circulo : Forma
    {
        public double Radio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public static Circulo operator *(Circulo circulo, double factor)
        {
            circulo.Radio *= factor;
            return circulo;
        }
    }
}