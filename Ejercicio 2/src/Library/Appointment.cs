using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        // Constructor de la clase
        public Appointment (Person patient, string doctor_name, DateTime date, string place)
        {
            this.Patient = patient;
            this.doctorName = doctor_name;
            this.Date = date;
            this.Place = place;
            this.isValid = true;
        }

        // Atributos de la clase
        public Person Patient { get; set; }
        public string doctorName { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }

        // Atributo isValid que me diga si el appointment es valido o no
        public bool isValid { get; set; }

        // Creo un método que me valide el appointment y me devuelva una cadena
        public string ValidateAppointment()
        {
            // Inicializo variable local
            StringBuilder stringBuilder = new StringBuilder();
        
            // Invoco al método ValidatePerson y concateno las cadenas
            stringBuilder.Append(Patient.ValidatePerson());

            // En caso de que el paciente no sea válido, que me baje la bandera
            if (!Patient.isValid)
            {
                this.isValid = false;
            }

            // Comprobación del lugar
            if (string.IsNullOrEmpty(this.Place))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                this.isValid = false;
            }

            // Comprobación de nombre del doctor
            if (string.IsNullOrEmpty(this.doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                this.isValid = false;
            }

            return stringBuilder.ToString();
        }
    }
}

/* 
La clase Appointment tiene la responsabilidad de conocer el appointment (cita) y validarlo
*/