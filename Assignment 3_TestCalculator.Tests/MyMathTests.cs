using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Assignment_3__TestCalculator;


namespace Assignment_3__TestCalculator.Tests
{
    public class MyMathTests
    {
        [Fact]
        public void AdditionTests()
        {
            double term1 = 0.5;
            double term2 = -9;
            double expected = -8.5;

            double result = MyMath.Addition(term1, term2);

            double[] terms = new double[3] { 1.5, 2.4, -3 };
            double expectedArray = 0.9;

            
            double resultArray = MyMath.Addition(terms);

            Assert.Equal(expected, result, 3);
            Assert.Equal(expectedArray, resultArray, 3);
        }

        [Fact]
        public void SubtractionTests()
        {
            double term1 = 0.5;
            double term2 = -9;
            double expected = 9.5;

            double result = MyMath.Subtraction(term1, term2);

            double[] terms = new double[3] { 1.5, 2.4, -3 };
            double expectedArray = 2.1;

            double resultArray = MyMath.Subtraction(terms);

            double[] oneTerm = new double[1] { 1 };
            double expectedofOne = 1;

            double resultofOne = MyMath.Subtraction(oneTerm);

            Assert.Equal(expected, result, 3);
            Assert.Equal(expectedArray, resultArray, 3);
            Assert.Equal(expectedofOne, resultofOne);
        }

        [Fact]
        public void MultiplicationTests()
        {
            double factor1 = 0.5;
            double factor2 = -9;
            double expected = -4.5;

            double result = MyMath.Multiplication(factor1, factor2);

            Assert.Equal(expected, result, 3);
        }

        [Fact]
        public void DivisionTests()
        {
            double num = 4;
            double den = 0;

            Assert.Throws<DivideByZeroException>(() =>  MyMath.Division(num, den));
        }
    }
}
