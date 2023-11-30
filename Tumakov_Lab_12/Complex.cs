namespace Tumakov_Lab_12
{
    class Complex
    {
        private double real;
        private double im;

        public Complex(double real, double im)
        {
            this.real = real;
            this.im = im;
        }
        public override bool Equals(object obj)
        {
            if (obj is Complex com)
            {
                if ((com.real == real) && (com.im == im))
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Complex operator +(Complex comp1, Complex comp2)
        {
            double real = comp1.real + comp2.real;
            double im = comp1.im + comp2.im;
            return new Complex(real, im);
        }

        public static Complex operator *(Complex comp1, Complex comp2)
        {
            double real = comp1.real * comp2.real - comp1.im * comp2.im;
            double im = comp1.real * comp2.im + comp1.im * comp2.real;
            return new Complex(real, im);
        }

        public static Complex operator -(Complex comp1, Complex comp2)
        {
            double real = comp1.real - comp2.real;
            double im = comp1.im - comp2.im;
            return new Complex(real, im);
        }

        public static bool operator ==(Complex comp1, Complex comp2)
        {
            return comp1.real == comp2.real && comp1.im == comp2.im;
        }

        public static bool operator !=(Complex complex1, Complex comp2)
        {
            return complex1.real != comp2.real || complex1.im != comp2.im;
        }

        public override string ToString()
        {
            return real + " + " + im + "i";
        }
    }
}
