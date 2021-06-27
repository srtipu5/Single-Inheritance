using System;

namespace Single_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.BookId = 001;
            book.BookName = "The Three Stooges";
            book.BookType = "Comedy";
            book.AuthorName = "Elwood Ullman";
            book.AuthorNationality = "America";
            Console.WriteLine(book.BookDetails());
            Console.ReadKey();
        }
    }
}
