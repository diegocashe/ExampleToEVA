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
            return this.nombre;
        }
    }

    public class Hombre:Persona
    {
        // ahora en el ambito de hombre tendremos disponibles los metodos
        // y atributos de la clase Persona
        // y le agrego metodos propios de la clase Hombre
        public Hombre(nombre){
            super(nombre)
        }

        public string getUpperCaseNombre(){
            return this.nombre
        }
    }   

     class Main
    {
        static void Main(string[] args)
        {
            //
            Hombre persona1 = new Hombre('Pedro');
            console.write(persona1.getNombre()) // => imprime Pedro
            console.write(persona1.getUpperCaseNombre()) // => imprime PEDRO
            
        }
    }