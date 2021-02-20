using System;
using System.Collections.Generic;

namespace GradeBookConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var book = new Book("");
            book.GradeAdded += OnGradeAdded;
            var done = false;
            var input = "";

            while (!done)
            {
                Console.Write("Please enter a grade or 'q' to quit: ");
                input = Console.ReadLine();

                if (input == "q")
                    done = true;
                else if (double.TryParse(input, out double grade))
                {
                    try
                    {
                        book.AddGrade(grade);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    Console.WriteLine("You did not enter a valid value. Try again...\n");
            }

            var stats = book.GetStatistics();

            Console.WriteLine("\nCalculating...\n");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The average grade is: {stats.Average:N1}");
            Console.WriteLine($"The letter grade is: {stats.Letter}");
        }

        public static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
