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
            Persona persona1 = new Persona('Pedro');
            // creo otro objeto diferente
            Persona persona2 = new Persona('Juan');

            console.write(persona1.nombre) // => imprime Pedro 
            console.write(persona2.nombre) // => imprime Juan 
        }
    }

   

    
}
