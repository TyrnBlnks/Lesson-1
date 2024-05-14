using System;
using System.Collections.Generic;

namespace Lesson_1
{
    class Program1
    {
        static void Main1()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter numbers to the list. Type 'end' to stop entering numbers.");

            // Using a while loop to accept user inputs until 'end' is entered
            while (true)
            {
                Console.Write("Enter a number (or 'end' to finish): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }
                if (int.TryParse(input, out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine("Invalid number, try again.");
                }
            }

            // Using a for loop to compute the sum of the list
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            // Printing the results
            Console.WriteLine("You entered the following numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"The total sum of these numbers is: {sum}");

            // Wait for user to end the program
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
