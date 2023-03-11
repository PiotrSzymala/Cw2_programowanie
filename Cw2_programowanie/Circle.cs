namespace Cw2_programowanie;

public class Circle
{
    private double _ray;
    public double Ray
    {
        get
        {
            return _ray;
        }
        set
        {
            if (value > 0)
            {
                _ray = value;
                _diameter = value * 2;
            }
            else
            {
                throw new Exception("Ray cannot equal or be less than zero");
            }
            
        }
    }

    private double _diameter;
    public double Diameter
    {
        get
        {
            return _diameter;
        }
        set
        {
            _diameter = value;
            _ray = value / 2;
        }
        
    }
    
    public double Field
    {
        get
        {
            return Math.PI * Math.Pow(_ray, 2);
        }
        
    }

    public double Circumference
    {
        get
        {
            return Math.PI * 2 * _ray;
        }
    }
    
    
    
    public Circle()
    {
        Ray = 1;
    }

    public Circle(int ray)
    {
        if (ray <= 0)
        {
            throw new Exception("Ray cannot equal or be less than zero");
        }

        Ray = ray;
    }
    
    public static bool AreCirclesEven (Circle c1, Circle c2)
    {
        if (c1.Ray == c2.Ray)
        {
            return true;
        }

        return false;
    }
}