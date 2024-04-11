using System;
using System.Text;

namespace Library
{
    public class Person
    {
        // Constructor de la clase
        public Person (string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        // Atributos de la clase
        public string Name { get; set; }
        public string Id { get; set; }

        // Creo un método que me diga si la persona creada es válida o no
        public bool isPersonValid()
        {
            // Inicializo variable local
            bool isValid = true;

            // Compruebo si el campo nombre es no vacío o distinto de espacios en blanco
            if (string.IsNullOrEmpty(this.Name))
            {
                Console.WriteLine("Se requiere que ingrese un nombre para que la persona sea válida");
                isValid = false;
            }
            
            // Compruebo si el campo id es no vacío o distinto de espacios en blanco
            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("Se requiere que ingrese una id para que la persona sea válida");
                isValid = false;
            }

            // Retorno la bandera que me dice si la persona es válida o no
            return isValid;
        }
    }
}