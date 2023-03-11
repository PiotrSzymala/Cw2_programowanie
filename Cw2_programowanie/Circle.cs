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
            }
            else
            {
                throw new Exception("Ray cannot equal or be less than zero");
            }
            
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
}