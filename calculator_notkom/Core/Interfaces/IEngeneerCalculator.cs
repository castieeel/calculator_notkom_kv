using calculator_notkom.Core.Interfaces;

namespace calculator_notkom.Core
{
    public interface IEngeneerCalculator : ICalculator
    {        
        double SqrtX(double a, double b);
        double Sqrt(double a);
        double Square(double a);
        double Factorial(double a);
        double DegreeY(double a, double b);
    }   
}
