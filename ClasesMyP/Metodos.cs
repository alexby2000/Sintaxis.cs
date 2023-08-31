
/* 
   Los métodos en C# son bloques de código que se pueden llamar varias veces para realizar una tarea específica. 
   Se pueden pensar como acciones que una clase puede realizar. Los métodos pueden tomar parámetros y devolver valores y se definen dentro de una clase.
    
   En las clases, los métodos se utilizan para encapsular la lógica de una funcionalidad específica.
   
   En C#, también es posible crear métodos con diferentes niveles de acceso.
   Por ejemplo, se pueden crear métodos públicos que puedan ser llamados desde cualquier parte del programa, o métodos privados que solo
   sean accesibles dentro de la clase.
*/

using System;

namespace ClasesMyp
{
    // METODO UTILIZANDO PARÁMETROS
    public class CorreoElectronico
    {
        public void EnviarMensaje(string destinatario, string asunto, string contenido)
        {
            // Lógica para enviar el correo electrónico al destinatario con el asunto y contenido especificado
        }
    }


    // RETORNO DE VALORES EN LOS METODOS
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;

        public Persona(string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int CalcularEdad()
        {
            DateTime ahora = DateTime.Now;
            int edad = ahora.Year - fechaNacimiento.Year;
            if (ahora.Month < fechaNacimiento.Month ||
                (ahora.Month == fechaNacimiento.Month && ahora.Day < fechaNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }
    }
}