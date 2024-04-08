using System;

namespace Ucu.Poo.Expert
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            book1.ShelveBook("A","7");
            book2.ShelveBook("B","3");

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