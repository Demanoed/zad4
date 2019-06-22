using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNum
{
    class Complex
    {
        public double r, i;
 
        public Complex()
        {
            this.r = 0.0;
            this.i = 0.0;
        }
        public Complex(double a, double b)
        {
            Complex res = new Complex();
            res.r = a;
            res.i = b;
        }
        public static Complex Sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r + b.r;
            res.i = a.i + b.i;
            return res;
        }
        public static Complex Multiplication(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r * b.r - a.i * b.i;
            res.i = a.i * b.r + a.r * b.i;
            return res;
        }
 
        public static Complex Subtract(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r - b.r;
            res.i = a.i - b.i;
            return res;
        }
 
        public static Complex operator +(Complex a, Complex b)
        {
            return Complex.Sum(a, b);
        }
 
        public static Complex operator -(Complex a, Complex b)
        {
            return Complex.Subtract(a, b);
        }
 
        public static Complex operator *(Complex a, Complex b)
        {
            return Complex.Multiplication(a, b);
        }
        public static Complex operator /(Complex a, Complex b)
        {
            double Denominator = b.r * b.r + b.i * b.i;
            return new Complex((a.r * b.r + a.i * b.i) / Denominator,
                (b.r * a.i - b.i * a.r) / Denominator);
        }
        public override string ToString()
        {
            return String.Format("{0} + i{1}", this.r, this.i);
        }
 
        public void Print(Complex a)
        {
            Console.Write(a);
        }
 
        public void PrintLine(Complex a)
        {
            Console.WriteLine(a);
        }
    }
}
