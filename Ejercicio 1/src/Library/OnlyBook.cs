using System;

namespace Ucu.Poo.Expert
{
    public class OnlyBook
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public OnlyBook(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}

/*
Ésta clase viola el principio SRP debido que tiene dos responsabilidades:
i) Conocer las características de un libro (autor, código, título, ubicación)
ii) Colocar el libro en un estante (método ShelveBook)
De éste modo, sería conveniente las responsabilidades creando otra clase la cual implemente el método "ShelveBook".
*/