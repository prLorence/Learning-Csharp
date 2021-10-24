using System;

namespace UsefulMethodsExample
{
    class Program
    {

        static double readValue (string prompt, double low, double high)
        {
            double result = 0;

            do
            {
                Console.WriteLine(prompt + " between " + low + " and " + high);
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
            } while (result < low || result > high);

            return result;
        }

        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;

        static void Main(string[] args)
        {
            double windowWidth = readValue("Enter width of window", MIN_WIDTH, MAX_WIDTH);

            Console.WriteLine("Width: " + windowWidth);

            double age = readValue("Enter your age ", 0, 70);

            Console.WriteLine("Age: ", age);

            if (age <= 17)
            {
                Console.WriteLine("You're too young for this sht go away.");
            }
            else
            {
                Console.WriteLine("Whats poppin broski");
            }

            Console.ReadLine();
        }
    }
}
