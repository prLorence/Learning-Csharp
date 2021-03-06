using System;

namespace GlazeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;

            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;

            string widthString, heightString;

            // asks for the width of the window
            Console.Write("Enter the width of the window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            if (width < MIN_WIDTH)
            {
                Console.WriteLine("Width is too small just like your pee pee. \n \n");
                Console.WriteLine("Using minimum width \n");
                width = MIN_WIDTH;
            }

            if (width > MAX_WIDTH)
            {
                Console.WriteLine("Width is too large, it won't fit. \n \n");
                Console.WriteLine("Using maximum width \n");
                width = MAX_WIDTH;
            }

            // asks for the height of the window
            Console.Write("Enter the height of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            if (height < MIN_HEIGHT)
            {
                Console.WriteLine("Height is too small uwu. \n \n");
                Console.WriteLine("Using minimum height \n");
                height = MIN_HEIGHT;
            }

            if (height > MIN_HEIGHT)
            {
                Console.WriteLine("Height is too large. \n \n");
                Console.WriteLine("Using maximum height \n");
                height = MAX_HEIGHT;
            }

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");

            Console.WriteLine("The area of the glass is " + glassArea + " square meters");

            Console.ReadLine();
        }
    }
}
