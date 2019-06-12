using System;


namespace Less6
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(3);
            fraction1.ShowFractionInfo();
            fraction1.ShowFractionReverse();

            Fraction fraction2 = fraction1.GetFractionReverse();
            fraction2.ShowFractionInfo();

        }
    }
}
