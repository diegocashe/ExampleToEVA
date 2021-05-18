using System;
namespace Examples

{ // ambito o scope global del programa
    
    public class Persona
    {
        // ambito de Persona

        private string nombre; 

        public Persona(string nombre)
        { 
            this.nombre = nombre;
        }

        public getNombre(){
            return toUpperCase(this.nombre);
        }
    }
    // La sintaxis de dos puntos me dice que la clase hombre hereda de la clase persona
    public class Hombre:Persona
    {
        public Hombre(nombre){
            // la funcion super hace el llamado al constructor de la clase padre
            super(nombre)
        }
    }   

     class Main
    {
        static void Main(string[] args)
        {
            //
            Hombre persona1 = new Hombre('Juan');
            console.write(persona1.getNombre()) // => imprime Pedro
            
        }
    }