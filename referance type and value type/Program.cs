using System;

namespace referance_type_and_value_type
{
    class Program
    {
        static void Main(string[] args)
        {
            //value type and reference type
            int x = 8;
            int y = 9;
            Console.WriteLine("Before swapping \n a=" + x + " b = " + y);
            Swap(ref x, ref y);
            Console.WriteLine("Before swapping \n a=" + x + " b = " + y);
        }
        static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("In swap method \n a=" + a + " b = " + b);
        }
    }
}
