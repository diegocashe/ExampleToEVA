using System;
namespace Examples

{ // ambito o scope global del programa

    public class Persona
    {
        // ambito de Persona
        public string nombre { get; } // se declara el atributo nombre
        public Persona(string nombre)
        { 
            this.nombre = nombre;
        }

    }

     class Main
    {
        static void Main(string[] args)
        {
            //este es un objeto que se basa(instancia) del modelo Persona 
            //new es una palabra reservada estandar para instanciar un objeto
            var persona1 = new Persona('Pedro');
            // creo otro objeto diferente
            var persona2 = new Persona('Juan');
        }
    }

   

    
}
