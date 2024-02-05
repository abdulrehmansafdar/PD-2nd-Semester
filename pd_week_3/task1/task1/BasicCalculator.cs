using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class BasicCalculator
    {


        double result;
        public double num1;
        public double num2;


        public BasicCalculator(double initialValue=10, double in2=10)
        {
            num1 = initialValue;
            num2 = in2;
        }

        public double Add(double operand, double in2)
        {
            result = operand + in2;

            return result;
        }

        public double Subtract(double operand, double in2)
        {
            result = operand - in2;
            return result;
        }

        public double Multiply(double operand, double in2)
        {
            result = operand * in2;
            return result;
        }

        public double Divide(double operand, double in2)
        {
           
                result = operand / in2;
                return result;
            

        }
        public double modulo(double operand, double in2)
        {
            result = operand % in2;
            return result;

        }
        public double sin(double operand)
        {
            result = Math.Sin(operand); 
            return result;

        }
        public double cos(double operand)
        {
            result = Math.Cos(operand);
            return result;

        }
        public double expo(double operand)
        {
            result = Math.Exp(operand);
            return result;

        }
        public double lg(double operand)
        {
            result = Math.Log(operand);
            return result;

        }
        public double sr(double operand)
        {
            result = Math.Sqrt(operand);
            return result;

        }
        public double tan(double operand)
        {
            result = Math.Tan(operand);
            return result;

        }


    }
}

