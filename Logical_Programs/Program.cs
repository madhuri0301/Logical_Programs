using System;

namespace Logical_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO The Logical Programs");

            Console.WriteLine("1.Perfect Number");
            Console.WriteLine("2.Prime Number");
            Console.WriteLine("3.Fibonacci Series");
            Console.WriteLine("4.Reverse Number");

            Console.WriteLine("Enter The Choice");

            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    PerfectNumber perfectnumber = new PerfectNumber();
                    perfectnumber.Number();
                    break;

                case 2:
                    PrimeNumber primenumber = new PrimeNumber();
                    primenumber.Prime();
                    break;

                case 3:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Series();
                    break;
            }
        }
    }
}
