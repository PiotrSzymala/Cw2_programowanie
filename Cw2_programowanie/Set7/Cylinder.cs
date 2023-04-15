using System.Drawing;

namespace Cw2_programowanie.Set7;

public class Cylinder
{
    private double _baseRay;
    private double _height;
    
    public Cylinder(double baseRay, double height)
    {
        _baseRay = baseRay;
        _height = height;
    }
    
    public Cylinder(Rectangle r1)
    {
        _baseRay = r1.A/2;
        _height = r1.B;
    }
    
    public double Volume    
    {
        get
        {
            return Math.PI * Math.Pow(_baseRay, 2) * _height;
        }
    }
    public double BaseField

    {
        get
        {
            return Math.PI * Math.Pow(_baseRay, 2);
        }
    }
    public double SideField
    {
        get
        {
            return 2 * Math.PI * _baseRay * _height;
        }
    }
}