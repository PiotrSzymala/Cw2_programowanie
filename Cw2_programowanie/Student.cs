namespace Cw2_programowanie;

public class Student
{
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value.Length > 2)
                _name = value;
        }
    }

    private string _surname;

    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            if (value.Length > 2)
            {
                _surname = value;
            }
        }
    }
    
    public int NrOfTheAlbum { get; set; }
    public double AverageGrade { get; set; }
}