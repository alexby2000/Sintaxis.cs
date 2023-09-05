
/*
    El encapsulamiento en C# es un concepto fundamental de la programación orientada a objetos que nos permite ocultar la implementación
    interna de una clase y proporcionar un control de acceso a sus miembros (métodos y propiedades). 
    En otras palabras, el encapsulamiento nos permite proteger los datos de una clase y definir cómo se accede a ellos desde otras partes del programa.

    La implementación del encapsulamiento en C# se basa en el uso de modificadores de acceso y propiedades. Los modificadores de acceso, 
    como public, private y protected, determinan la visibilidad y el nivel de acceso de los miembros de una clase. Por otro lado, 
    las propiedades permiten definir métodos especiales para acceder y modificar los datos de una clase de manera controlada.
*/

using System;

namespace ClasesEncapsulamiento
{
    /*
     
     En este ejemplo, la clase "CuentaBancaria" encapsula los campos "titular" y "saldo" mediante propiedades. 
     Esto permite controlar el acceso a estos datos y asegurarse de que se cumplan las reglas de negocio. Además, los métodos "Depositar"
     y "Retirar" proporcionan una interfaz controlada para realizar operaciones en la cuenta bancaria.

    */
    public class CuentaBancaria
    {
        private string titular;
        private decimal saldo;

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Depositar(decimal cantidad)
        {
            saldo += cantidad;
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo en la cuenta.");
            }
        }
    }
}