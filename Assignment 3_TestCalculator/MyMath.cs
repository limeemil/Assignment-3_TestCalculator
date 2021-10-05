using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3__TestCalculator
{
    public static class MyMath
    {
        

        public static double Addition(double term1, double term2)
        {
            return term1 + term2;
        }

        public static double Addition(double[] terms)
        {
            double sum = 0;
            for (int i = 0; i < terms.Length; i++)
            {
                sum += terms[i];
            }

            return sum;
        }

        public static double Subtraction(double term1, double term2)
        {
            return term1 - term2;
        }

        public static double Subtraction(double[] terms)
        {
            double diff = terms[0];
            if (terms.Length == 1)
            {
                return diff;
            }
            for (int i = 1; i < terms.Length; i++)
            {
                diff -= terms[i];
            }

            return diff;
        }

        public static double Multiplication(double factor1, double factor2)
        {
            return factor1 * factor2;
        }

        public static double Division(double num, double den)
        {
            if (den == 0)
            {
                throw new DivideByZeroException();
            }

            return num / den;
        }
    }
}
