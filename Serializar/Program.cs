using System;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Serializar
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos clientes = new Datos();
            {
                clientes.nombre = "Jeremias";
                clientes.apellido = "Paez";
                clientes.edad = 25;
                clientes.sexo = 'M';
                clientes.dni = 42354789;
                clientes.ingresos = 250000;

            }


            string myJson = JsonSerializer.Serialize(clientes);
            File.WriteAllText("clientes.json", myJson);

        }
    }
}