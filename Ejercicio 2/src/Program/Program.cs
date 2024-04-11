using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);

            // Creación de personas
            Person steven = new Person("Steven Jhonson","986782342","5555-555-555");
            Person ralf = new Person("Ralf Manson", "","5555-555-555");
            Person armand = new Person("Dr.Armand","972122344","5555-555-555");

            // Creación de appointments
            Appointment citaSteven = new Appointment(steven,armand,DateTime.Now, "Wall Street");
            Appointment citaRalf = new Appointment(ralf,armand,DateTime.Now, "Queen Street");

            // Imprimo appointments
            Console.WriteLine(Service.GetAppointment(citaSteven));
            Console.WriteLine(Service.GetAppointment(citaRalf));
        }
    }
}
