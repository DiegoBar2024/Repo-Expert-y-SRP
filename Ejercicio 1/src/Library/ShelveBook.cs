using System;

namespace Ucu.Poo.Expert
{
    // Ésta clase únicamente tiene la responsabilidad de ubicar un libro
    public class OnlyShelveBook
    {
        public static void ShelveBook(String sector, String shelve, OnlyBook book)
        {
            book.LibrarySector = sector;
            book.LibraryShelve = shelve;
        }
    }
}