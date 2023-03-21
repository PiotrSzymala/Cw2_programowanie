using Cw2_programowanie.RegisteringBookSystem.Models;

namespace Cw2_programowanie.RegisteringBookSystem;

public class BookManager
{
    public static List<Book> Books { get; set; } = new List<Book>();

    public BookManager(List<Book> books)
    {
        Books = books;
    }
    
    public static void Run()
    {
        ShowMenu();
        string input;
        bool flag = false;
        do
        {
           input  = Console.ReadLine();

           switch (int.Parse(input))
           {
               case 1:
                   CheckList(AddAuthor);
                   
                   break;
                   
               case 2:
                   CheckList(AddPublisher);
                   
                   break; 
               
               case 3:
                   AddBook();
                   break;
                   
               case 4:
                   BookDisplayer.DisplayBooks(Books);
                   break;
               
               case 5:
                   Console.WriteLine("Shutting down...");
                   flag = true;
                   break;
           }
        } while (!flag);
    }

    private static void ShowMenu()
    {
        Console.WriteLine("1 - Add Author to the book.");
        Console.WriteLine("2 - Add Publishing Company to the book.");
        Console.WriteLine("3 - Add Book to the book list.");
        Console.WriteLine("4- Display books.");
        Console.WriteLine("5 - Exit.");
        Console.WriteLine();
    }

    private static Author CreateAuthor()
    {
        Console.WriteLine("Give Author's name: ");
        var authorsName = Console.ReadLine();

        Console.WriteLine("Give Author's second name (optional): ");
        var authorSecondName = Console.ReadLine();

        Console.WriteLine("Give Author's surname: ");
        var authorSurname = Console.ReadLine();

        Console.WriteLine("Give Author's pseudonym: ");
        var authorPseudonym = Console.ReadLine();

        Author result = new Author(authorsName, authorSecondName, authorSurname, authorPseudonym);

        return result;
    }

    private static Book CreateBook(Author author)
    {
        Console.WriteLine("Give Book's title: ");
        var title = Console.ReadLine();
        
        Console.WriteLine("Give Book's original title: ");
        var originalTitle = Console.ReadLine();
        
        Console.WriteLine("Give Book's publication date: ");
        var publicationDate = DateTime.Parse(Console.ReadLine());
        
        Console.WriteLine("Give Book's publishing company: ");
        var publishingCompany = Console.ReadLine();
        
        Console.WriteLine("Give Book's ISBN number: ");
        var numberISBN = int.Parse(Console.ReadLine());

        Book result = new Book(author, title, originalTitle, publicationDate, publishingCompany, numberISBN);

        return result;
    }
    private static void AddBook()
    {
        var authorToAdd = CreateAuthor();

        var book = CreateBook(authorToAdd);
        
        Books.Add(book);
    }

    private static void AddAuthor()
    {
        Console.WriteLine("To which book you want to add author: ");
        var search = Console.ReadLine();

        Book result = Books.First(b => b.Title.Contains(search));

        var authorToAdd = CreateAuthor();
        result.Authors.Add(authorToAdd);
    }

    private static void AddPublisher()
    {
        Console.WriteLine("To which book you want to add publisher?: ");
        var search = Console.ReadLine();
        
        Book result = Books.First(b => b.Title.Contains(search));

        Console.WriteLine("Give publisher: ");
        var publisherToAdd = Console.ReadLine();
        
        result.PublishingCompany.Add(publisherToAdd);
    }

    private static void CheckList(Action del)
    {
        if (Books.Count == 0)
        {
            Console.WriteLine("You can't do this, book list is empty. Add book first.");
            
        }
        else
        {
            del.Invoke();
        }
    }
}