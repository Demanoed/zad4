﻿using System;

namespace ComplexNum
{
    class Complex
    {
        #region Переменные для целой и мнимой части
        private double m_real;
        private double m_imag;
        #endregion
        #region Конструкторы
        public Complex(double re)
        {
            m_real = re;
            m_imag = 0.0;
        }
        public Complex(double re, double im)
        {
            m_real = re;
            m_imag = im;
        }
        public Complex(Complex x)
        {
            m_real = x.Real;
            m_imag = x.Imag;
        }
        #endregion
        #region Свойства 
        public double Real
        {
            get { return m_real; }
            set { m_real = value; }
        }
        public double Imag
        {
            get { return m_imag; }
            set { m_imag = value; }
        }
        #endregion
        #region Доп функции
        public double Abs
        {
            get { return Math.Sqrt(m_imag * m_imag + m_real * m_real); }
        }
        public double Arg
        {
            get { return Math.Atan(m_imag / m_real); }
        }
        #endregion
        #region Получение комплексно-сопряженного числа
        public Complex GetConjugate()
        {
            return new Complex(m_real, -m_imag);
        }
        #endregion
        #region Преобразование в строку
        public override string ToString()
        {
            string res = "";

            if (m_real != 0.0)
            {
                res = m_real.ToString();
            }

            if (m_imag != 0.0)
            {
                if (m_imag > 0)
                {
                    res += "+";
                }

                res += m_imag.ToString() + "i";
            }
            return res;
        }
        #endregion
        #region Перегруженные операторы сложения
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imag + c2.Imag);
        }
        public static Complex operator +(Complex c1, double c2)
        {
            return new Complex(c1.Real + c2, c1.Imag);
        }
        public static Complex operator +(double c1, Complex c2)
        {
            return new Complex(c1 + c2.Real, c2.Imag);
        }
        #endregion
        #region Перегруженные операторы вычитания
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imag - c2.Imag);
        }
        public static Complex operator -(Complex c1, double c2)
        {
            return new Complex(c1.Real - c2, c1.Imag);
        }
        public static Complex operator -(double c1, Complex c2)
        {
            return new Complex(c1 - c2.Real, -c2.Imag);
        }
        #endregion
        #region Перегруженные операторы умножения
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Real * c2.Real - c1.Imag * c2.Imag,
                c1.Real * c2.Imag + c1.Imag * c2.Real);
        }
        public static Complex operator *(Complex c1, double c2)
        {
            return new Complex(c1.Real * c2, c1.Imag * c2);
        }
        public static Complex operator *(double c1, Complex c2)
        {
            return new Complex(c1 * c2.Real, c1 * c2.Imag);
        }
        #endregion
        #region Перегруженные операторы деления
        public static Complex operator /(Complex c1, Complex c2)
        {
            double Denominator = c2.Real * c2.Real + c2.Imag * c2.Imag;
            return new Complex((c1.Real * c2.Real + c1.Imag * c2.Imag) / Denominator,
                (c2.Real * c1.Imag - c2.Imag * c1.Real) / Denominator);
        }
        public static Complex operator /(Complex c1, double c2)
        {
            return new Complex(c1.Real / c2, c1.Imag / c2);
        }
        public static Complex operator /(double c1, Complex c2)
        {
            double Denominator = c2.Real * c2.Real + c2.Imag * c2.Imag;
            return new Complex((c1 * c2.Real) / Denominator, (-c2.Imag * c1) / Denominator);
        }
        #endregion
        #region Перегруженный оператор ==
        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Real == c2.Real && c1.Imag == c2.Imag;
        }
        #endregion
        #region Перегруженный оператор !=
        public static bool operator !=(Complex c1, Complex c2)
        {
            return c1.Real != c2.Real || c1.Imag != c2.Imag;
        }
        #endregion
        #region Перегруженный Equals
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }

            return this == (Complex)obj;
        }
        #endregion
        #region Перегруженное получение хэш-кода
        public override int GetHashCode()
        {
            return m_real.GetHashCode() + m_imag.GetHashCode();
        }
        #endregion
    }
}
