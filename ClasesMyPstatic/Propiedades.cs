using System;

namespace MyPstatic
{
    // PROPIEDADES ESTATICAS

    // Propiedad estática para contar instancias
    public class MiClase
    {
        private static int _contador = 0;

        public MiClase()
        {
            _contador++;
        }

        public static int Contador
        {
            get { return _contador; }
        }
    }

    // Propiedad estática para configurar una conexión a una base de datos
    public class ConexionBD
    {
        private static string _cadenaConexion;

        public static string CadenaConexion
        {
            get { return _cadenaConexion; }
            set { _cadenaConexion = value; }
        }

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
