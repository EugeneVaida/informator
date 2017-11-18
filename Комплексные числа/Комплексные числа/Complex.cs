using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Комплексные_числа
{
    class Complex
    {

        public double r, i;

        public Complex( double a, double b)
        {
            i = a;
            r = b;
        }        
        
        public override string ToString()
        {
            //return (i.ToString() + " " + r.ToString);
            return $"{i} {r}";
        }

        public static Complex operator + (Complex A, Complex B)
        {
            Complex result = new Complex(A.i, B.r);
            result.i = A.i + B.i;
            result.r = A.r + B.r;

            return result;
        }

        public static Complex operator / (Complex A, Complex B)
        {
            Complex result = new Complex(A.i, B.r);
            result.i = A.i * B.i;
            result.r = A.r * B.r;

            return result;
        }

        public static Complex operator * (Complex A, Complex B)
        {
            Complex result = new Complex(A.i, B.r);
            result.i = A.i / B.i;
            result.r = A.r / B.r;

            return result;
        }






    }
}
