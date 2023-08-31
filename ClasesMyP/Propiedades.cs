
/*
  Las propiedades son elementos clave en la programación orientada a objetos, ya que permiten definir atributos para las clases y
  acceder a ellos de manera controlada.
  En C#, las propiedades son una forma de encapsular variables y asegurar que su acceso y modificación sean realizados de manera segura y coherente.

  Las propiedades son miembros de una clase que se comportan como variables, pero que se acceden mediante métodos especiales llamados "getters" y "setters".
  Los getters y setters permiten leer y escribir los valores de las propiedades, respectivamente, y permiten que la clase controle el acceso a los datos.
*/


using System;

namespace ClasesMyP
{
    // EJEMPLO 1 DE PROPIEDADES EN CLASES
    public class Persona
    {
        private string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentException("El nombre debe tener entre 2 y 50 caracteres.");
                }
                nombre = value;
            }
        }
        // Resto de la implementación de la clase Persona
    }


    // EJEMPLO 2 DE PROPIEDADES EN CLASES
    public class Empleado
    {
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Edad
        {
            get
            {
                DateTime fechaActual = DateTime.Now;
                int edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
                {
                    edad--;
                }
                return edad;
            }
        }
    }

    // PROPIEDADES DE SOLO LECTURA Y ESCRITURA EN CLASES

    // SOLO LECTURA 
    public class Factura
    {
        private decimal _total;

        public Factura(decimal total)
        {
            _total = total;
        }

        public decimal Total
        {
            get { return _total; }
        }
    }

    // LECTURA Y ESCRITURA
    public class Producto
    {
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
