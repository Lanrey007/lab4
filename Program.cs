using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lessThan100(22, 15));
            Console.WriteLine(lessThan100(83, 34));
            Console.WriteLine(lessThan100(3, 77));
            Console.ReadLine();
            //int result > (x + y);
        }

      public static bool lessThan100(int x, int y)
        {
            return (x + y < 100);
        }
    }
}
