namespace Cw2_programowanie;
public class Point
{
    public int X, Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Quadruple
{
    private double _circumference;

    public double Circumference
    {
        get
        {
            return _circumference;
        }
        set
        {
            _circumference = value;
        }
    }
    public Point A { get; set; }
    public Point B { get; set; }
    public Point C { get; set; }
    public Point D { get; set; }

    
    public Quadruple(Point a, Point b, Point c, Point d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }

    public static double CalculateDistance(Point p1, Point p2)
    {
        return Math.Sqrt((Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)));
    }

    public static double CalculateCircumference(Point a, Point b, Point c, Point d)
    {
        var ab = CalculateDistance(a, b);
        var bc = CalculateDistance(b, c);
        var cd = CalculateDistance(c, d);
        var da = CalculateDistance(d, a);

        return ab + bc + cd + da;
    }
}