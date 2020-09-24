using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().TestCode();
        }

        void TestCode()
        {
            var addOp = new RunDelegeate(Plus);

            Calc(6, 2, addOp);
            
            
            Console.WriteLine(Plus(6, 2));


            Calc(6, 2, Minus);

        }

        //private delegate T MyDelegate<T>(T a, T b);

        public delegate int RunDelegeate(int a, int b);


        void Calc(int a, int b, RunDelegeate calc)
        {
            //int result = 0;
            int res = calc(a, b);
            //return res;

            Console.WriteLine( $"f({a},{b}) = {res}");
        }


        int Plus(int a, int b)
        {
            return a + b;
        }

        int Minus(int a, int b)
        {
            return a - b;
        }

        double Multiply(double a, double b)
        {
            return a * b;
        }

        double Division(double a, double b)
        {
            return a / b;
        }

        
    }
}
