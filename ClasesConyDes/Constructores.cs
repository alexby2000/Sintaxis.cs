
/*
    Un constructor en C# es un miembro especial de una clase que se utiliza para inicializar objetos de esa clase. 
    Se llama automáticamente cuando creamos un objeto de una clase. Los constructores tienen el mismo nombre que la clase 
    a la que pertenecen y no devuelven ningún valor.

    En el contexto de la programación, el constructor es quien nos permite establecer los valores iniciales para los campos de
    nuestros objetos, o incluso realizar cualquier otro tipo de configuraciones iniciales necesarias. 
    Podemos tener varios constructores en una clase, cada uno con diferentes parámetros. Esto permite la creación de objetos de
    la misma clase de diferentes maneras.
*/

using System;

namespace ClasesConyDes
{
    // CONSTRUCTORES CON PARÁMETROS
    public class Auto
    {
        public string marca;
        public string modelo;

        public Auto(string marca, string modelo)
        {
            // this es una palabra clave que se usa para referirse al objeto actual. 
            // this.marca se refiere al campo marca del objeto que está siendo creado, mientras que marca se refiere al parámetro del constructor.

            this.marca = marca;
            this.modelo = modelo;
        }

        Auto miAuto = new Auto("Toyota", "Corolla"); // Creación del objeto
    }

    // CONSTRUCTORES ESTÁTICOS

    /* 
        Los constructores estáticos son un tipo especial de constructor que se ejecuta solo una vez, cuando se accede a la clase por primera vez.
        Se utiliza para inicializar cualquier dato estático o para realizar acciones específicas que necesitan ocurrir solo una vez. 
        Se declaran con la palabra clave static.
    */
    public class Moto
    {
        static Moto()
        {
            // Código del constructor estático
        }
    }


    // EJEMPLO DE CONSTRUCTOR
    public class Libro
    {
        public string titulo;
        public string autor;
        public decimal precio;

        public Libro(string titulo, string autor, decimal precio)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.precio = precio;
        }

        Libro miLibro = new Libro("1984", "George Orwell", 9.99m);
    }
}