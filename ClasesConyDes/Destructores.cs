
/*
    Un destructor en C# es un método especial que se utiliza para limpiar cualquier recurso que el objeto pueda haber adquirido durante su vida. 
    Se llaman automáticamente cuando un objeto está a punto de ser destruido, es decir, cuando el recolector de basura de .NET decide que el objeto 
    ya no es accesible y puede ser eliminado de la memoria.

    Los destructores tienen el mismo nombre que la clase, precedido por un tilde (~), y no pueden tener parámetros ni modificadores de acceso.

    A diferencia de otros lenguajes de programación, como C++, en C# no tienes que llamar explícitamente a los destructores. 
    El recolector de basura de .NET se encarga de eso por ti. Sin embargo, si tu clase adquiere algún recurso que .NET no conoce, 
    como un archivo o una conexión de red, es tu responsabilidad liberar esos recursos en el destructor.   
*/

using System;

namespace ClasesConyDes
{
    /*
        Los destructores son útiles cuando tu clase tiene referencias a recursos no administrados que .NET no sabe cómo limpiar. 
        Los recursos no administrados son aquellos que no están bajo el control del recolector de basura, como las conexiones a 
        bases de datos, los punteros de archivos y las conexiones de red.
    */

    public class Bici
    {
        private IntPtr buffer; // Un recurso no administrado

        public Bici()
        {
            // Aquí se asigna algo al buffer
        }

        ~Bici()
        {
            // Libera el recurso no administrado
            Marshal.FreeHGlobal(buffer);
        }
    }



    // EJEMPLO PRÁCTICO DE DESTRUCTORES

    public class ConexionBaseDatos
    {
        // sqlConnection no existe porque habría que definirlo previamente. Esto es simplemente un ejemplo.

        private SqlConnection conexion;

        public ConexionBaseDatos(string cadenaConexion)
        {
            // Abrir la conexión a la base de datos
            conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
        }

        ~ConexionBaseDatos()
        {
            // Cerrar la conexión a la base de datos cuando el objeto se destruye
            if (conexion != null)
            {
                conexion.Close();
            }
        }

        public void MiMetodo()
        {
            ConexionBaseDatos conexion = new ConexionBaseDatos("cadenaConexion");

            // Usar la conexión para interactuar con la base de datos

        } // Al finalizar el método, el objeto 'conexion' sale del ámbito y el destructor se llama
    }

}