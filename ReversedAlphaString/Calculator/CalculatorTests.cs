using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalculatorT
{
    [TestFixture]
    class CalculatorTests
    {
        Calculator<int> calcInt;
        Calculator<double> calcDouble;
        [SetUp]
        public void Init()
        {
            calcInt = new Calculator<int>();
            calcDouble = new Calculator<double>();
        }

        [TestCase(1, 0, 1)]
        [TestCase(0, 1, 1)]
        [TestCase(-1, 1, 0)]
        [TestCase(int.MaxValue, 1, int.MinValue)]
        public void CheckAddInt(int a, int b, int expected)
        {
            int actual = calcInt.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0, 1)]
        [TestCase(0, 1, -1)]
        [TestCase(-1, 1, -2)]
        [TestCase(int.MinValue, 1, int.MaxValue)]
        public void CheckSubtractInt(int a, int b, int expected)
        {
            int actual = calcInt.Subtract(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(-1, 1, -1)]
        [TestCase(int.MaxValue, 0, 0)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]
        public void CheckMultiplyInt(int a, int b, int expected)
        {
            int actual = calcInt.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0)]
        public void CheckDivideByZeroException(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => calcInt.Divide(a, b));
        }

        [TestCase(0, 1, 0)]
        [TestCase(-1, 1, -1)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]
        [TestCase(int.MinValue, 1, int.MinValue)]
        public void CheckDivideInt(int a, int b, double expected)
        {
            double actual = calcInt.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 0)]
        public void CheckDivideByZeroInt(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => calcInt.Divide(a, b));
        }

        [TestCase(1.2, 0, 1.2)]
        [TestCase(0, 0.0, 0.0)]
        [TestCase(-1.1, 1, -0.1)]
        [TestCase(double.MaxValue, 1, double.MaxValue)]
        [TestCase(double.PositiveInfinity, 1, double.PositiveInfinity)]
        [TestCase(double.NegativeInfinity, -1, double.NegativeInfinity)]
        [TestCase(double.NegativeInfinity, double.PositiveInfinity, double.NaN)]
        public void CheckAddDouble(double a, double b, double expected)
        {
            double actual = calcDouble.Add(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestCase(1.2, 0, 1.2)]
        [TestCase(0, 0.0, 0.0)]
        [TestCase(-1.1, 1, -2.1)]
        [TestCase(double.MinValue, 1, double.MinValue - 1)]
        [TestCase(double.PositiveInfinity, 1, double.PositiveInfinity)]
        [TestCase(double.NegativeInfinity, -1, double.NegativeInfinity)]
        [TestCase(double.NegativeInfinity, double.PositiveInfinity, double.NegativeInfinity)]
        [TestCase(double.PositiveInfinity, double.NegativeInfinity, double.PositiveInfinity)]
        public void CheckSubtractDouble(double a, double b, double expected)
        {
            double actual = calcDouble.Subtract(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestCase(1.2, 0, 0)]
        [TestCase(0, 0.0, 0.0)]
        [TestCase(-1.1, -1, 1.1)]
        [TestCase(double.PositiveInfinity, 1, double.PositiveInfinity)]
        [TestCase(double.NegativeInfinity, -1, double.PositiveInfinity)]
        [TestCase(double.NegativeInfinity, double.PositiveInfinity, double.NegativeInfinity)]
        [TestCase(double.PositiveInfinity, double.NegativeInfinity, double.NegativeInfinity)]
        [TestCase(double.MinValue, -1, double.MaxValue)]
        public void CheckMultipplyDouble(double a, double b, double expected)
        {
            double actual = calcDouble.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1.1, 1, -1.1)]
        [TestCase(-1.1, -1, 1.1)]
        [TestCase(7, 3, 2.33)]
        [TestCase(0, -1, 0)]
        [TestCase(0.1, 0.1, 1)]
        public void CheckDivideDouble(double a, double b, double expected)
        {
            double actual = calcDouble.Divide(a, b);
            Assert.AreEqual(expected, actual, 0.01); 
        }

        [TestCase(1.2, 0)]
        [TestCase(0, 0)]
        public void CheckDivideByZeroExceptionDouble(double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() => calcDouble.Divide(a, b));
        }

        [TestCase(double.PositiveInfinity, 1)]
        [TestCase(double.NegativeInfinity, -1)]
        [TestCase(double.NegativeInfinity, double.PositiveInfinity)]
        [TestCase(double.PositiveInfinity, double.NegativeInfinity)]
        public void CheckNotFiniteNumberExceptionDouble(double a, double b)
        {
            Assert.Throws<NotFiniteNumberException>(() => calcDouble.Divide(a, b));
        }
    }
}
