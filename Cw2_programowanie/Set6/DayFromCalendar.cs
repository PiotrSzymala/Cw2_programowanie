namespace Cw2_programowanie.Set6;

public class DayFromCalendar
{
    private int _day;
    public int Day
    {
        get
        {
            return _day;
        }

        set
        {
            if (value <= 31)
            {
                _day = value;
            }
        }
    }

    private int _month;
    public int Month
    {
        get
        {
            return _month;
        }
        
        set
        {
            if (value <= 12)
            {
                _month = value;
            }
        }
    }

    private int _year;
    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            if (value >= 0)
            {
                _year = value;
            }
        }
    }

    public DateTime Date { get; set; }
   
    public DayFromCalendar(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;

        Date = new DateTime(year, month, day);

    }
    

    public override string ToString()
    {
        return $"{Date.ToShortDateString()}";
    }

    public static DateTime operator +(DayFromCalendar day, int numOfDaysToAdd)
    {

        return day.Date.AddDays(numOfDaysToAdd);
    }
    
    public static DateTime operator -(DayFromCalendar day, int numOfDaysToSubtract)
    {

        return day.Date.AddDays(-numOfDaysToSubtract);
    }
}