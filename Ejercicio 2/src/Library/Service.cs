using System;
using System.Text;

namespace Library
{
    public class Service
    {
        public static string GetAppointment(Appointment appointment)
        {
            // Creo la cadena en donde voy a guardar la cadena
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            stringBuilder.Append(appointment.ValidateAppointment());

            if (appointment.isValid)
            {
                stringBuilder.Append("Apointment scheduled");
            }

            // Retorno la cadena correspondiente
            return stringBuilder.ToString();
        }
    }
}

/*
La clase Service tiene la responsabilidad de generar la cadena del appointment a imprimir
*/