using System;
namespace Examples

{ // ambito o scope global del programa

    public class Persona
    {
        // ambito de Persona
        // private es una palabra reservada que me indica que en dato que se use solo sera accesible a traves 
        // de su propia clase

        private string nombre; // se declara el atributo nombre con la palabra reservada private

        public Persona(string nombre)
        { 
            this.nombre = nombre;
        }

        // la palabra reservada public me permite declararle al programa, 
        //un dato que pueda ser accesible desde cualquier 
        //lugar del programa a traves de la clase 

        public getNombre(){
            return this.nombre;
        }

        //esto en c# se maneja de manera diferente 
        //pero para ambitos educativos algo parecido en la mayoria de lenguajes 
        //de programacion se declaran los getters y setters
    }

     class Main
    {
        static void Main(string[] args)
        {
            //
            Persona persona1 = new Persona('Pedro');
            console.write(persona1.getNombre()) // => imprime Pedro
            console.write(persona1.nombre) // => imprime Pedro ERROR de referencia
            
        }
    }
