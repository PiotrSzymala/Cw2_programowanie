using Cw2_programowanie.RegisteringBookSystem.Models;

namespace Cw2_programowanie.RegisteringBookSystem;

public static class BookDisplayer
{
    public static void DisplayBooks(List<Book> books)
    {
        foreach (var book in books)
        {
            Console.WriteLine("Author: ");
            foreach (var author in book.Authors)
            {
                Console.WriteLine(author);
            }

            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Original title: {book.OriginalTitle}");
            Console.WriteLine($"Publication date: {book.PublicationDate}");
            Console.WriteLine($"Publishing company: {book.PublishingCompany}");
            Console.WriteLine($"ISBN number: {book.ISBN}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}