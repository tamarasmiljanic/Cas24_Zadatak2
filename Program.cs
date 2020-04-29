using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas24_Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite racunsku operaciju:");
            string op = Console.ReadLine();
            Console.Write("Unesite prvi broj>");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite drugi broj>");
            double b = Convert.ToDouble(Console.ReadLine());
            
            if ((b > a) && ((op=="-") || (op=="/"))) 
                SimpleCalculations.Swap(ref a,ref b);
            Console.WriteLine("{0} {1} {2} = {3:0.00}", a, op, b, SimpleCalculations.Calc(op, a, b));
            Console.ReadKey();
        }
    }
}
