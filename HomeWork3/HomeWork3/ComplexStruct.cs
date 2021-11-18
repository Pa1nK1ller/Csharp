using System;

namespace HomeWork3_1
{

    struct ComplexStruct
    {
        public double re;
        public double im;

        public ComplexStruct Plus(ComplexStruct complex)
        {
            ComplexStruct resultComplexPlus = new();
            resultComplexPlus.re = re + complex.re;
            resultComplexPlus.im = im + complex.im;
            return resultComplexPlus;
        }
        public ComplexStruct Minus(ComplexStruct complex)
        {
            ComplexStruct resultComplexMinus = new();
            resultComplexMinus.re = re - complex.re;
            resultComplexMinus.im = im - complex.im;
            return resultComplexMinus;
        }
        public ComplexStruct Divis(ComplexStruct complex)
        {
            ComplexStruct resultComplexDivis = new();
            resultComplexDivis.re = (re * complex.re + im * complex.im) / (Math.Pow(complex.re, 2) + Math.Pow(complex.im, 2));
            resultComplexDivis.im = (complex.re * im - re * complex.im) / (Math.Pow(complex.re, 2) + Math.Pow(complex.im, 2));
            return resultComplexDivis;
        }
        public ComplexStruct Multi(ComplexStruct complex)
        {
            ComplexStruct resultComplexMulti = new();
            resultComplexMulti.re = re * complex.re - im * complex.im;
            resultComplexMulti.im = re * complex.im + complex.re * im;
            return resultComplexMulti;
        }
        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
}
