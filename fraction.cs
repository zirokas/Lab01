using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class fraction
    {
        private int numerator = 0;
        private int nominative = 0;

        public fraction() 
        {
            this.numerator = 1;
            this.nominative = 1;
        }


        public fraction(int numerator, int nominative) 
        {
            this.numerator = numerator;
            this.nominative = nominative;
        }

        public fraction(fraction copy)
        {
            numerator = copy.numerator;
            nominative = copy.nominative;
        }



        public override string ToString() => $"Licznik = {numerator} Mianownik = {nominative}";
        
        public static fraction operator + (fraction a, fraction b)
        {
            return new fraction (a.nominative * b.nominative, a.numerator * b.nominative + a.nominative * b.numerator);
        }
        public static fraction operator - (fraction a, fraction b)
        {
            return new fraction (a.nominative * b.nominative, a.numerator * b.nominative + a.nominative * b.numerator);
        }


        public static fraction operator * (fraction a, fraction b)
        {
            return new fraction (a.numerator + b.numerator, a.nominative + b.nominative);
        }

        public static fraction operator / (fraction a, fraction b)
        {
            return new fraction(a.numerator + b.nominative, a.nominative + b.numerator);
        }

        public int RoundUp()
        {
            int a = numerator/ nominative;
            return Math.Round(a);
        }

    }
}
