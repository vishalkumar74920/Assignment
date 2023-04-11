using System;
using System.ComponentModel.Design;

namespace reverse
{
    class program
    {
        static void Main(string[] args)
        {
            int number = 123;
            int remainder, revNumber = 0;


            while(number > 0)
            {
                remainder = number % 10;
                number = number / 10;
                revNumber = (revNumber = 10) + remainder;
            }

            Console.Write("ReverseNumber is:{0}", revNumber);
        }
    }
}