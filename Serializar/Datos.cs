using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;

namespace Serializar
{
  public class Datos
  {
    public string? nombre { get; set; }
    public string? apellido { get; set; }
    public int edad { get; set; }
    public char sexo { get; set; }
    public int dni { get; set; }
    public int ingresos { get; set; }
    

  }
}
