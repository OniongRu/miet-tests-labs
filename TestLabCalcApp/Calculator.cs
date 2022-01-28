using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLabCalcApp
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Sub(double a, double b)
        {
            return a - b;
        }

        public static double Mult(double a, double b)
        {
            return a * b;
        }

        public static double Div(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }

    }
}
