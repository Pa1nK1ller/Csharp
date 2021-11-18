using System;

namespace HomeWork3_1
{
    class Fractions
    {
        int numerator, denominator;

        public int Numerator
        {
            get => numerator;
            set
            {
                numerator = value;
            }
        }
        public int Denominator
        {
            get => denominator;
            set
            {
                if (value == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                else
                    denominator = value;
            }
        }

        public Fractions()
        {
            numerator = 1;
            denominator = 1;
        }

        public Fractions(int numer, int denomin)
        {
            Numerator = numer;
            Denominator = denomin;
        }

        public Fractions Plus(Fractions fractions)
        {

            Fractions fractions1 = new();
            fractions1.denominator = NOZ(fractions.denominator, denominator);
            fractions1.numerator = (fractions.numerator * (fractions1.denominator / fractions.denominator)) + (numerator * (fractions1.denominator / denominator));
            return fractions1;
        }
        public Fractions Minus(Fractions fractions)
        {
            Fractions fractions1 = new();
            fractions1.denominator = NOZ(fractions.denominator, denominator);
            fractions1.numerator = (numerator * (fractions1.denominator / denominator)) - (fractions.numerator * (fractions1.denominator / fractions.denominator));
            return fractions1;
        }
        public Fractions Multiply(Fractions fractions)
        {
            Fractions fractions1 = new();
            fractions1.numerator = fractions.numerator * numerator;
            fractions1.denominator = fractions.denominator * denominator;
            return fractions1;
        }
        public Fractions Divide(Fractions fractions)
        {
            Fractions fractions1 = new();
            fractions1.numerator = numerator * fractions.denominator;
            fractions1.denominator = denominator * fractions.numerator;
            return fractions1;
        }

        static int NOZ(int x, int y)
        {
            int noz, newnoz, multiplier = 2;
            if (x > y)
            {
                noz = x;
                if (noz % y == 0)
                    return noz;
            }
            else
            {
                noz = y;
                if (noz % x == 0)
                    return noz;
            }
            while (true)
            {
                newnoz = noz * multiplier;
                if (newnoz % x == 0 && newnoz % y == 0)
                    return newnoz;
                multiplier++;
            }
        }

        static int NOD(int x, int y)
        {
            while (x != y)
            {
                if (x == 0)
                    break;
                if (x > y) x -= y;
                else y -= x;
            }
            return x;
        }

        public void Simplification()
        {
            int num = this.numerator;
            int denom = this.denominator;
            int nod = NOD(Math.Abs(num), Math.Abs(denom));
            while (nod != 1 && nod != 0)
            {
                this.numerator = num / nod;
                this.denominator = denom / nod;
                num = this.numerator;
                denom = this.denominator;
                nod = NOD(Math.Abs(num), Math.Abs(denom));
            }
        }
        public double DecimalFraction
        {
            get => Math.Round((double)numerator / denominator, 2);
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
