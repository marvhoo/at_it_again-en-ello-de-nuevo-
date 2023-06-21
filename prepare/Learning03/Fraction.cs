
// The follwoing code will be class that stores nummeric values, to be specific, fractions.
class Fraction
{

    private int numerator, denominator;
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int wholeNumber)
    {
        numerator = wholeNumber;
        denominator = 1;
    }

    public Fraction(int _numerator, int _denominator)
    {
        numerator = _numerator;
        denominator = _denominator;
    }


    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value != 0)
                denominator = value;
            else
                throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)numerator / (double)denominator;
    }
}

