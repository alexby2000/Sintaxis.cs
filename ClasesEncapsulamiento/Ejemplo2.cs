using System;

namespace ClasesEncapsulamiento
{
    /*
     
     En este ejemplo, la clase "Empleado" encapsula los campos "nombre", "edad" y "salario" mediante propiedades. 
     Esto permite proteger los datos y controlar su acceso y modificación. El método "AumentarSalario" proporciona una forma controlada
     de aumentar el salario de un empleado en base a un porcentaje dado.

    */

    public class Empleado
    {
        private string nombre;
        private int edad;
        private decimal salario;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public void AumentarSalario(decimal porcentaje)
        {
            salario += salario * porcentaje / 100;
        }
    }
}
