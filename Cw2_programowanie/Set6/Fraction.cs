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
    
    public static Fraction  operator+(Fraction f1, Fraction f2)
    {
        Fraction fraction;

        if (f1.Denominator == f2.Denominator)
        {
            return  new Fraction(f1.Numerator + f2.Numerator, f1.Denominator);
            
        }

        return new Fraction((f1.Numerator * f2.Denominator) + (f2.Numerator * f1.Denominator),
            f1.Denominator * f2.Denominator);
    }

    public static Fraction ReduceFraction(Fraction fraction)
    {
        int gcd = GCD(fraction.Numerator, fraction.Denominator);
        
        int reducedNumerator = fraction.Numerator/gcd;
        int reducedDenominator = fraction.Denominator/gcd;
        
        return new Fraction(reducedNumerator, reducedDenominator);
    }
    
   private static int GCD(int a, int b)
    {
        while (b > 0)
        {
            int rem = a % b;
            a = b;
            b = rem;
        }
        return a;
    }
}