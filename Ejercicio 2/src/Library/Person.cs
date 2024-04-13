using System;
using System.Text;

namespace Library
{
    public class Person
    {
        // Constructor de la clase
        public Person (string name, string id, string number)
        {
            this.Name = name;
            this.Id = id;
            this.phoneNumber = number;
            this.isValid = true;
        }

        // Atributos de la clase
        public string Name { get; set; }
        public string Id { get; set; }
        public string phoneNumber { get; set; }

        // Atributo isValid que me diga si la persona es válida o no
        public bool isValid { get; set; }

        public string ValidatePerson()
        {
            // Inicializo variable local
            StringBuilder stringBuilder = new StringBuilder();

            // Comprobación de nombre
            if (string.IsNullOrEmpty(this.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                this.isValid = false;
            }

            // Comprobación de Id
            if (string.IsNullOrEmpty(this.Id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                this.isValid = false;
            }

            // Comprobación de numero de telefono
            if (string.IsNullOrEmpty(this.phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                this.isValid = false;
            }

            // Retorno la cadena
            return stringBuilder.ToString();
        }
    }
}

/*
La clase original CreateAppointment incumple con el principio SRP debido que tiene las siguientes responsabilidades:
i) Generar la cadena del appointment
ii) Realizar todas las validaciones correspondientes a los datos
iii) Tener conocimiento de información acerca de personas y del appointment que no precisa para cumplir con la responsabilidad de imprimir
De éste modo, se opta por crear tres clases: una clase Person que se encarga de conocer personas, otra clase Appointment que se encarga de conocer el appointment y finalmente otra que se encargue de hacer sólo la impresión
En ésta solapa se implementa la clase Person que se encarga de conocer la persona.
*/