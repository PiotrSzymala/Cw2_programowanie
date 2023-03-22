using Cw2_programowanie.RegisteringBookSystem.Models;

namespace Cw2_programowanie.RegisteringBookSystem;

public static class BookDisplayer
{
    public static void DisplayBooks()
    {
        foreach (var book in BookManager.Books)
        {
            var form = book.Authors.Count <= 1 ? "Author": "Authors";

            Console.WriteLine(form);
            
            foreach (var author in book.Authors)
            {
                Console.WriteLine("  "+author);
            }

            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Original title: {book.OriginalTitle}");
            Console.WriteLine($"Publication date: {book.PublicationDate}");
            Console.WriteLine($"Publishing company: ");
            foreach (var publisher in book.PublishingCompany)
            {
                Console.WriteLine("  "+publisher);
            }
            Console.WriteLine($"ISBN number: {book.ISBN}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}