using masala.Models;

namespace Masala
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Oq kema");
            book.Muallifi = "Chingiz Aytmatov";
            book.Narxi = 100000;

            // book.PrintKitobNomi();
            // book.PrintKitobMuallif();
            // book.PrintKitobNarxi();

            //or
            book.PrintAll();
        }
    }
}