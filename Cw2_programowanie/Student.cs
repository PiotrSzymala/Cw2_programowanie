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

    private int _nrOfTheAlbum;
    public int NrOfTheAlbum
    {
        get
        {
            return _nrOfTheAlbum;
        }
        set
        {
            if (value > 0)
            {
                _nrOfTheAlbum = value;
            }
        }
    }

    private double _averageGrade;

    public double AverageGrade
    {
        get
        {
            return _averageGrade;
        }
        set
        {
            if (value > 0)
            {
                _averageGrade = value;
            }
        }
    }
}