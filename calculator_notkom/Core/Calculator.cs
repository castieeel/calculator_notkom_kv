using calculator_notkom.Core.Interfaces;
using System;

namespace calculator_notkom.Core
{
    public class Calculator : ICalculator
    {
        public double Dev(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("На 0 делить нельзя!");
            return a / b;
        }

        public double Multi(double a, double b)
        {
            return a * b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
