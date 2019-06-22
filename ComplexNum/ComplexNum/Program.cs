using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemanT_Library;

namespace ComplexNum
{
    class Program
    {
        private static Complex u, v, w, res;
        private static void CreateComplexNum()
        {
            double u1, u2, v1, v2, w1, w2;
            ColorMess.Yellow("\n Введите целую часть комплексного числа u: ");
            u1 = Input.Check(double.MinValue, double.MaxValue);
            ColorMess.Yellow("\n Введите мнимую часть комплексного числа u: ");
            u2 = Input.Check(double.MinValue, double.MaxValue);
            Console.Clear();
            ColorMess.Yellow("\n Введите целую часть комплексного числа v: ");
            v1 = Input.Check(double.MinValue, double.MaxValue);
            ColorMess.Yellow("\n Введите мнимую часть комплексного числа v: ");
            v2 = Input.Check(double.MinValue, double.MaxValue);
            Console.Clear();
            ColorMess.Yellow("\n Введите целую часть комплексного числа w: ");
            w1 = Input.Check(double.MinValue, double.MaxValue);
            ColorMess.Yellow("\n Введите мнимую часть комплексного числа w: ");
            w2 = Input.Check(double.MinValue, double.MaxValue);
            Console.Clear();
            u = new Complex(u1, u2);
            v = new Complex(v1, v2);
            w = new Complex(w1, w2);
        }
        private static Complex Formula()
        {
            Complex res = 2*u+(3*u*w)/(2+w-u)-7;
            return new Complex(res);
        }
        static void Main()
        {
            CreateComplexNum();
            res = Formula();
            ColorMess.Cyan("\n Результат вычисления формулы равен: "+res);
            Message.GoToBack();
        }
    }
}
