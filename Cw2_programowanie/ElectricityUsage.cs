using System;

public class ElectricityUsage
{
    public double PastUsage { get; set; }

    private double _actualUsage;

    public double ActualUsage
    {
        get
        {
            return _actualUsage;
        }
        set
        {
            if (value > PastUsage)
            {
                _actualUsage = value;
            }
        }
    }

    public ElectricityUsage(double pastUsage)
    {
        PastUsage = pastUsage;
    }

    public static double CalculateUsage(double pastUsage, double actualUsage)
    {
        return actualUsage - pastUsage;
    }
}
