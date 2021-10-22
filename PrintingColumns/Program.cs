using System;

namespace PrintingColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            // formatting standard for thousand numbers
            int i = 150;
            double f = 1234.56789;
            Console.WriteLine("Printing standard format");
            Console.WriteLine("i: {0:#, ##0} f:{1:##,##0.00} \n", i, f);

            // printing columns
            Console.WriteLine("Printing columns (appearing to the right side)");
            Console.WriteLine("i: {0,10:0} f: {1,15:0.00}", i, f);
            Console.WriteLine("i: {0,10:0} f: {1,15:0.00} \n", 0, 0);

            Console.WriteLine("Printing columns (appearing to the left side)");
            Console.WriteLine("i: {0,-10:0} f: {1,-15:0.00}", i, f);
            Console.WriteLine("i: {0,-10:0} f: {1,-15:0.00}", 0, 0);


            Console.ReadLine();
        }
    }
}
