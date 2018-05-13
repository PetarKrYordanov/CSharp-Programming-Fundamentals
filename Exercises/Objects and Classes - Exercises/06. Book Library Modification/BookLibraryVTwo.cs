using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06._Book_Library_Modification
{
    class BookLibraryVTwo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> myBooks = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book();
                book.Tittle = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = input[4];
                book.Price = double.Parse(input[5]);

                myBooks.Add(book);
            }
            DateTime finalDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library myLibrary = new Library();
            myLibrary.Books = myBooks;

            foreach (var book in myLibrary.Books.Where(x => x.ReleaseDate > finalDate)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Tittle))
            {
                Console.WriteLine($"{book.Tittle} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }
    }
    public class Book
    {
        public string Tittle { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }

    }
    public class Library
    {
        public String Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
