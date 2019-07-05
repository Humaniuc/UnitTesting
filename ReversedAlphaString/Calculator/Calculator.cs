using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.Math;

namespace CalculatorT
{
    public class Calculator<T> where T:struct
    {
        public T Add(T a, T b)
        {
            return GenericMath<T>.Add(a, b);
        }
        public T Subtract(T a, T b)
        {
            return GenericMath<T>.Subtract(a, b);
        }
        public T Multiply(T a, T b)
        {
            return GenericMath<T>.Multiply(a, b);
        }
        public T Divide<T>(T a, T b)
        {
            switch (b)
            {
                case 0:
                    throw new DivideByZeroException("Numerator is zero");
                case 0.0:
                    throw new DivideByZeroException("Numerator is zero");
                case double.PositiveInfinity:
                    throw new NotFiniteNumberException("Numerator is positive infinity");
                case double.NegativeInfinity:
                    throw new NotFiniteNumberException("Numerator is negative infinity");
                default:
                    switch(a)
                    {
                        case double.NegativeInfinity:
                            throw new NotFiniteNumberException("Denumerator is negative infinity");
                        case double.PositiveInfinity:
                            throw new NotFiniteNumberException("Denumerator is positive infinity");
                        default:
                            return GenericMath<T>.Divide(a, b);
                    }
            }
        }
    }
}
