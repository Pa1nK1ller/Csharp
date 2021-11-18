using System;


namespace HomeWork3_1
{
    class ComplexClass
    {

        #region Поля (Fields)

        private double im;
        private double re;

        #endregion

        #region Свойства

        public double Im
        {
            get
            {
                return im;
            }

            set
            {
                if (value == 0)
                {
                    throw new Exception("Недопустимое значение.");
                }

                im = value;
            }
        }

        public double Re
        {
            get
            {
                return re;
            }

            set
            {
                re = value;
            }
        }

        #endregion

        #region Конструктор класса

        public ComplexClass(double re, double im)
        {
            if (im == 0)
            {
                throw new Exception("Недопустимое значение.");
            }

            this.re = re;
            this.im = im;

        }

        public ComplexClass()
        {

        }

        #endregion

        #region Поведение (Methods)

        public ComplexClass Plus(ComplexClass complex)
        {
            return new ComplexClass(this.re + complex.re, this.im + complex.im);
        }

        public ComplexClass Minus(ComplexClass complex)
        {
            return new ComplexClass(this.re - complex.re, this.im - complex.im);
        }

        public ComplexClass Multi(ComplexClass complex)
        {
            return new ComplexClass(this.re * complex.re - this.im * complex.im, this.re * complex.im + this.im * complex.re);
        }

        public ComplexClass Divis(ComplexClass complex)
        {

            return new ComplexClass((this.re * complex.re + this.im * complex.im) / (Math.Pow(complex.re, 2) + Math.Pow(complex.im, 2)), (complex.re * this.im - this.re * complex.im) / (Math.Pow(complex.re, 2) + Math.Pow(complex.im, 2)));
        }

        #endregion

        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
}
