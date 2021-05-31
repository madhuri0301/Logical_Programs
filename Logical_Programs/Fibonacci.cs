using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Fibonacci
    {
        int a = 0;
        int b = 1;
        int c;
        public void Series()
        {
            Console.WriteLine("Fibonacci Series :");
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}


