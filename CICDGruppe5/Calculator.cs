using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CICDGruppe5
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        { 
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double? Divide(double a, double b)
        {
            if (b == 0) return null;
            return a / b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double SquareRoot(double a)
        {
            if (a < 0) return double.NaN;
            return Math.Sqrt(a);
        }

    }
}
