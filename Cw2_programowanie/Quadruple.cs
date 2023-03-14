namespace Cw2_programowanie;
public class Point
{
    public int X, Y;
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
            
        }
    }
    public Point X1 { get; set; }
    public Point Y1 { get; set; }
    public Point X2 { get; set; }
    public Point Y2 { get; set; }
    
    
    public Quadruple(Point x1, Point y1, Point x2, Point y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public double CalculateDistance(Point p1, Point p2)
    {
        return ((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
    }
}