using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    public class PrimeNumber
    {
        int i, k = 0;
        public void Prime()
        {
            Console.WriteLine("Write Any Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                Console.WriteLine("The Number Is Prime");
            }
            else
            {
                Console.WriteLine("The Number Is not Prime");
            }
        }


    }

}
