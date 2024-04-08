using System;

namespace Ucu.Poo.Expert
{
    public class OnlyShelveBook
    {
        public static void ShelveBook(String sector, String shelve, OnlyBook book)
        {
            book.LibrarySector = sector;
            book.LibraryShelve = shelve;
        }
    }
}