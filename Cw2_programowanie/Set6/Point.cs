namespace Cw2_programowanie.Set6;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Point operator *(Point point, int k)
    {
        return new Point(point.X * k, point.Y * k);
    }
    
    public static bool operator ==(Point p1, Point p2)
    {
        if (p1.X == p2.X && p1.Y == p2.Y)
            return true;

        return false;
    }

    public static bool operator !=(Point p1, Point p2)
    {
        if (p1.X != p2.X && p1.Y != p2.Y)
            return true;

        return false;
    }

    public override string ToString()
    {
        return $"x: {X}, y: {Y}";
    }
}