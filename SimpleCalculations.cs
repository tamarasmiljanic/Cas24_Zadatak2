using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas24_Zadatak2
{
    class SimpleCalculations
    {
        public static double Calc(string op, double a, double b)
        {
            double r = 0;
            switch (op)
            {
                case "+":
                    r = SimpleCalculations.Add(a, b);
                    break;
                case "-":
                    r = SimpleCalculations.Substract(a, b);
                    break;
                case "*":
                    r = SimpleCalculations.Multiply(a, b);
                    break;
                case "/":
                    r = SimpleCalculations.Divide(a, b);
                    break;
            }
            return r;
        }
            
    public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Substract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("!DIV0-nije dozvoljeno deljenje nulom");
                return 0;
            }
        }
        public static void Swap(ref double a, ref double b)
        {
            double pom;
            pom = a;
            a = b;
            b = pom;
        }
    }
}
