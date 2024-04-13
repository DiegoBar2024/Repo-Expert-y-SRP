using System;

namespace Ucu.Poo.Expert
{
    class Program
    {
        static void Main()
        {
            // Creo dos insta
            OnlyBook libro1 = new OnlyBook("Design Patterns","Erich Gamma & Others","001-034");
            OnlyBook libro2 = new OnlyBook("Pro C#","Troelsen","001-035");
            OnlyShelveBook.ShelveBook("A","7",libro1);
            OnlyShelveBook.ShelveBook("B","3",libro2);

            Console.WriteLine(libro1.LibrarySector);
            Console.WriteLine(libro2.LibrarySector);
            Console.WriteLine(libro1.LibraryShelve);
            Console.WriteLine(libro2.LibraryShelve);
        }
    }
}