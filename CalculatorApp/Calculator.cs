using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{
    public class Calculator
    {
        public float Add(float a, float b)
        {
            return a + b;
        }

        public float Subtract(float a, float b)
        {
            return a - b;
        }

        public float Multiply(float a, float b)
        {
            return a * b;
        }

        public float Multiply(float a, float b, float c)
        {
            return a * b * c;
        }

        public float Divide(float a, float b)
        {
            return (float) a / b;
        }
    }
}
