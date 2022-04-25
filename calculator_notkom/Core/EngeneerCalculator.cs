using System;

namespace calculator_notkom.Core.Interfaces
{    
        //Реализация структурного паттерна декортатор
        public class EngeneerCalculator : IEngeneerCalculator
        {

            private ICalculator _calculator;
       

            public EngeneerCalculator(ICalculator calculator)
            {
                //Например некая дополнительная функциональность или логика для работы 
                // с сложением            
                _calculator = calculator;
            }

            public double Sum(double a, double b)
            {
                return _calculator.Sum(a, b);
            }

            public double Sub(double a, double b)
            {
                return _calculator.Sub(a, b);
            }

            public double Multi(double a, double b)
            {
                return _calculator.Multi(a, b);
            }

            public double Dev(double a, double b)
            {
                return _calculator.Dev(a, b);
            }

            public double SqrtX(double a, double b)
            {
                return Math.Pow(a, 1 / b);
            }

            public double Sqrt(double a)
            {
                return Math.Sqrt(a);
            }

            public double Square(double a)
            {
                return Math.Pow(a, 2.0);
            }

            public double Factorial(double a)
            {
                double f = 1;

                for (int i = 1; i <= a; i++)
                    f *= (double)i;

                return f;
            }
            public double DegreeY(double a, double b)
            {
                return Math.Pow(a, b);
            }
        }
}
