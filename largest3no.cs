using System;

namespace example_program
{
    class program
    {
        static void main(string[] args)
        {
            int n1, n2, n3, largest;
            Console.WriteLine("Enter the number 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 3");
            n3 = Convert.ToInt32(Console.ReadLine());

                if (n1 > n2 && n1 > n3)
                largest = n1;
            else if (n2 > n1 && n2 > n3)
                largest = n2;
            else
                largest = n3;


            Console.WriteLine("Largest amoug{0},{1} and{2} is {3}", n1, n2, n3, largest);
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}