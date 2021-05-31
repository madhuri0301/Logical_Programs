using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class ReverseNumber
    {
        int num = 1234;
        int result = 0;
        int rem;
        public void Reverse()
        {
            while (num != 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(result);
        }
    }
}