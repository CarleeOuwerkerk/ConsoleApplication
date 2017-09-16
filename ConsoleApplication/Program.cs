using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World.");
            Console.WriteLine("Carlee Kristin Murphy");
            Console.WriteLine("United States of America");

            string firstName = "Carlee";
            Console.WriteLine("Hello, " + firstName + "!");

            //creates instance of DateTime and displays today's date
            var date = DateTime.Now;
            Console.WriteLine($"Today's date is {date.ToString("MMMMMMMMM dd, yyyy")}.");

            //displays and labels number of days until Christmas
            var christmas = new DateTime(2017, 12, 25);
            TimeSpan numberUntilChristmas = christmas - DateTime.Today;
            Console.WriteLine($"There are {numberUntilChristmas.TotalDays} days until Christmas!");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            // This will cause the program to pause in the console.
            // It waits for the user to press enter.
            Console.ReadLine();
        }
    }
}