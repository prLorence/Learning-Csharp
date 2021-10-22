using System;

namespace LearningMethods
{
    class Program
    {
        static void doit()
        {
            Console.WriteLine("Hello");
        }

        static void silly (int i)
        {
            Console.WriteLine("i is: " + i);
        }

        static int sillyReturnPlus(int i)
        {
            i = i + 1;
            Console.WriteLine("i is: " + i);
            return i;
        }

        static void Main(string[] args)
        {
            doit();
            doit();

            silly(404);
            silly(21);

            int res;
            res = sillyReturnPlus(5) + sillyReturnPlus(7) + 1; // the first sillyReturnPlus returns 6 the second sillyReturnPlus returns 8 which results to 14 then adds 1 so the sum is 15
            Console.WriteLine("res is: " + res);

            Console.ReadLine();
        }
    }
}
