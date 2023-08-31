
/* 
   A continuación, veremos un ejemplo práctico que ilustra el uso de métodos y propiedades virtuales en una jerarquía de clases que
   modela diferentes tipos de vehículos para un sistema de ventas de autos.
   
   En este ejemplo, consideraremos una jerarquía de clases que incluye la clase base "Vehiculo" y dos clases derivadas: "Auto" y "Camioneta".
   Cada clase tendrá propiedades específicas como marca, modelo y precio, así como un método virtual llamado "CalcularDescuento"
   que calculará el descuento aplicado al precio del vehículo.
*/

using System;

namespace MyPvirtual
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }

        public virtual double CalcularDescuento()
        {
            return 0; // No se aplica descuento por defecto
        }
    }

    public class Auto : Vehiculo
    {
        public override double CalcularDescuento()
        {
            return Precio * 0.1; // Se aplica un descuento del 10% para autos
        }
    }

    public class Camioneta : Vehiculo
    {
        public override double CalcularDescuento()
        {
            return Precio * 0.15; // Se aplica un descuento del 15% para camionetas
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Marca = "Toyota";
            auto.Modelo = "Corolla";
            auto.Precio = 25000;

            Camioneta camioneta = new Camioneta();
            camioneta.Marca = "Ford";
            camioneta.Modelo = "Ranger";
            camioneta.Precio = 35000;

            Console.WriteLine($"Descuento para el auto: {auto.CalcularDescuento()}");
            Console.WriteLine($"Descuento para la camioneta: {camioneta.CalcularDescuento()}");
        }
    }
}
