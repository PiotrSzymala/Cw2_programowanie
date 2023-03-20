namespace Cw2_programowanie.RegisteringBookSystem.Models;

public class Author
{
    public string Name { get; set; }
    public string? SecondName { get; set; }
    public string Surname { get; set; }
    public string Pseudonym{ get; set; }

    public Author(string name, string? secondName, string surname, string pseudonym)
    {
        Name = name;
        SecondName = secondName;
        Surname = surname;
        Pseudonym = pseudonym;
    }

    public override string ToString()
    {
        return $"Name: {Name}, second name: {SecondName}, surname: {Surname}, pseudonym: {Pseudonym}";
    }
}