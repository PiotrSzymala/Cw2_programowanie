namespace Cw2_programowanie.RegisteringBookSystem.Models;

public class Book
{
    public List<Author> Authors { get; set; } = new List<Author>();
    public string Title { get; set; }
    public string OriginalTitle { get; set; }
    public DateTime PublicationDate { get; set; }
    public List<string> PublishingCompany { get; set; } = new List<string>();
    public int ISBN { get; set; }

    public Book(Author author, string title, string originalTitle, DateTime publicationDate, string publishingCompany, int isbn)
    {
        Authors.Add(author);
        Title = title;
        OriginalTitle = originalTitle;
        PublicationDate = publicationDate;
        PublishingCompany.Add(publishingCompany);
        ISBN = isbn;
    }
}