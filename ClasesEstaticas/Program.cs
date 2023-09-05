
/*
    Las clases estáticas en C# son aquellas que no pueden ser instanciadas ni extendidas. Funcionan de manera global en tu aplicación
    y están diseñadas para contener métodos y propiedades que no dependen del estado de un objeto específico.  

    Usar clases estáticas es como tener un cinturón de herramientas bien organizado: siempre sabes qué herramienta usar y dónde encontrarla.
    Así que, si estás buscando una forma de hacer tu código más eficiente y claro, las clases estáticas podrían ser tu mejor aliado.
*/

using System;

namespace ClasesEstaticas
{
    // EJEMPLO DE CALCULADORA FINANCIERA

    // Realiza operaciones financieras específicas cada vez que se necesita llamarla.
    // Se llama al metodo CalculadoraFinanciera.CalcularInteresSimple(...)

    public static class CalculadoraFinanciera
    {
        public static decimal CalcularInteresSimple(decimal capital, decimal tasa, int tiempo)
        {
            return capital * tasa * tiempo;
        }

        // Otros métodos financieros...
    }




    // EJEMPLO DE CONFIGURACIONES GLOBALES

    // Contiene propiedades estaticas con valores que son leidos sólo una vez desde un archivo de configuración externo.
    // El acceso a las configuraciones se vuelve rápido y eficiente porque se leen las propiedades y no el archivo desde 0.

    public static class ConfiguracionesGlobales
    {
        public static string CadenaConexionBD { get; set; }
        public static int TiempoMaximoEspera { get; set; }

        // Otras propiedades de configuración...
    }




    // EXTENSIÓN DE MÉTODOS

    //  Estos permiten "añadir" métodos a tipos ya existentes sin tener que modificarlos directamente.

    public static class ExtensionesString
    {
        public static bool EsPalindromo(this string palabra)
        {
            var palabraRevertida = new string(palabra.Reverse().ToArray());
            return palabra == palabraRevertida;
        }
    }
}