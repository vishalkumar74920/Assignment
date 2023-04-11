using System;
namespace inheratice
{
    class A
    {
        int a = 200, b = 100, c;

        public void add()
        {
            c = a + b;
            Console.WriteLine("Addition" + c);
        }
        public void sub()
        {
            c = a - b;
            Console.WriteLine("Subtraction" + c);
        }
    }
    class B
    {
        static void main(string[] args)
        {
            A r = new();
            r.add(); r.sub();

        }
    }
}