using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class PerfectNumber
    {
        public int sum = 0;
        public void Number()
        {
            Console.WriteLine("Enter The Number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    sum = sum + i;
            }
            if (sum == num)
                Console.WriteLine(" It is a Perfect Number");
            else
                Console.WriteLine("It Is Not a Perfect Number");

        }

    }
}

