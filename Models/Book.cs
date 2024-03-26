using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala.Models
{
    public class Book
    {
        private string _muallifi;
        private decimal _narxi;
        public string Muallifi
        { 
            get { return _muallifi; }
            set { _muallifi = value; } 
        }
        public decimal Narxi
        {
            get {return _narxi;}
            set {_narxi = value;}
        }
        private string _kitobNomi;
        public Book(string kitobNomi)
        {
            _kitobNomi = kitobNomi;
        }

        public void PrintKitobNomi()
        {
            System.Console.WriteLine($"Kitob nomi: {_kitobNomi}");
        }
        public void PrintKitobMuallif()
        {
            System.Console.WriteLine($"Kitob muallifi: {Muallifi}");
        }
        public void PrintKitobNarxi()
        {
            System.Console.WriteLine($"Kitob narxi: {Narxi}");
        }

        public void PrintAll()
        {
            System.Console.WriteLine($"Kitob nomi: {_kitobNomi}\nKitob muallifi: {Muallifi}\nKitob narxi: {Narxi}");
        }
    }
}
