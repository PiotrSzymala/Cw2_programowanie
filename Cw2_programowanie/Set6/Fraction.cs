namespace Cw2_programowanie.Set6;

public struct Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }
    
    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
    
}