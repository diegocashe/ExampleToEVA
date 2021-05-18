using System;
namespace Examples

{ // ambito o scope global del programa

    //el ambito o alcance (scope) de los atributos son netamente dentro de cada clase y esta se mantiene como una caja negra
    
    public class EsUnaClase
    {
        //Ambito o scope de la clase EsUnaClase
        public decimal atributo1 { get; } // los metodos get nos permites enviar valores a un objeto sin acceder a sus atributos
        public DateTime atributo2  { get; } // esto es por encapsulamiento
        public string atributo3 { get; }

        // Este metodo se conoce como constructor y es el que instancia la clase para crear objetos
        // La palabra 
        public EsUnaClase(decimal atributo1, DateTime atributo2, string atributo3)
        { 
            // la palabra reservada this identifica que se habla del ambito del objeto en que se utiliza.
            this.atributo1 = atributo1;
            this.atributo2 = atributo2;
            this.atributo3 = atributo3;
        }

    }
}
