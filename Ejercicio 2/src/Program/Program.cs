using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación de personas
            Person steven = new Person("Steven Jhonson","986782342","5555-555-555");
            Person ralf = new Person("Ralf Manson", "","5555-555-555");

            // Creación de appointments
            Appointment appointmentSteven = new Appointment(steven,"armand",DateTime.Now, "Wall Street");
            Appointment appointmentRalf = new Appointment(ralf,"",DateTime.Now, "Queen Street");

            // Imprimo appointments
            Console.WriteLine(Service.GetAppointment(citaSteven));
            Console.WriteLine(Service.GetAppointment(citaRalf));
        }
    }
}
