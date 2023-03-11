namespace Cw2_programowanie;

public class Circle
{
    public double Ray { get; set; }
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
        else
        {
            Ray = ray;
        }
    }
}