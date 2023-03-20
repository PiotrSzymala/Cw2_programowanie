namespace Cw2_programowanie.RegisteringBookSystem.Models;

public class Book
{
    public List<Author> Authors { get; set; }
    public string Title { get; set; }
    public string OriginalTitle { get; set; }
    public DateTime PublicationDate { get; set; }
    public string PublishingCompany { get; set; }
    public int ISBN { get; set; }

    public Book(List<Author> authors, string title, string originalTitle, DateTime publicationDate, string publishingCompany, int isbn)
    {
        Authors = authors;
        Title = title;
        OriginalTitle = originalTitle;
        PublicationDate = publicationDate;
        PublishingCompany = publishingCompany;
        ISBN = isbn;
    }
}