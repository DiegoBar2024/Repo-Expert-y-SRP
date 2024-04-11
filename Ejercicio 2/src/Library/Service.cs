using System;
using System.Text;

namespace Library
{
    public class Service
    {
        public static string GetAppointment(Appointment appointment)
        {
            // Creo la cadena en donde voy a guardar la cadena
            StringBuilder stringAppointment = new StringBuilder("Agendando cita...\n");

            // En caso de que la cita sea válida (llamo al método de Appointment) que me confirme que está todo bien
            if (appointment.isAppointmentValid())
            {
                stringAppointment.Append("Cita agendada correctamente");
            }

            // En caso de que la cita no sea válida, le digo al usuario que revise los datos ingresados
            else
            {
                stringAppointment.Append("Error al agendar cita. Comprobar datos ingresados");
            }

            // Retorno la cadena correspondiente
            return stringAppointment.ToString();
        }
    }
}