using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        // Constructor de la clase
        public Appointment (Person patient, Person doctor, DateTime date, string place)
        {
            this.Patient = patient;
            this.Doctor = doctor;
            this.Date = date;
            this.Place = place;
        }

        // Atributos de la clase
        public Person Patient { get; set; }
        public Person Doctor { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }

        // Creo un método que me diga si la cita es válida o no
        public bool isAppointmentValid()
        {
            // Inicializo variable local
            bool isValid = true;

            // Compruebo si la persona Paciente es valida
            if (!Patient.isPersonValid())
            {
                Console.WriteLine("Compruebe que los datos del paciente sean correctos");
                isValid = false;
            }

            // Compruebo si la persona Doctor es valida
            if (!Doctor.isPersonValid())
            {
                Console.WriteLine("Compruebe que los datos del doctor sean correctos");
                isValid = false;
            }

            // Compruebo que el lugar de la cita sea válido
            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                Console.WriteLine("Se requiere que ingrese un lugar para que la cita sea válida");
                isValid = false;
            }

            // Compruebo que la fecha de la cita sea válida
            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                Console.WriteLine("Se requiere que ingrese un lugar para que la cita sea válida");
                isValid = false;
            }

            // Retorno la bandera que me dice si la persona es válida o no
            return isValid;
        }
    }
}