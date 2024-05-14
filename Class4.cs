using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_1
{
    class Class4
    {
        static void Fifth()
        {
            List<int> numbers = new List<int>();
            string userInput;
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Number");
                Console.WriteLine("2. Calculate Sum");
                Console.WriteLine("3. Calculate Average");
                Console.WriteLine("4. Display All Numbers");
                Console.WriteLine("5. Remove Number");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1": // Add Number
                        Console.Write("Enter a number to add: ");
                        if (int.TryParse(Console.ReadLine(), out int numToAdd))
                        {
                            numbers.Add(numToAdd);
                            Console.WriteLine($"{numToAdd} has been added.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case "2": // Calculate Sum
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine($"The sum of all numbers is: {sum}");
                        break;

                    case "3": // Calculate Average
                        if (numbers.Count > 0)
                        {
                            double average = numbers.Average(); // Using LINQ to calculate average
                            Console.WriteLine($"The average of all numbers is: {average:N2}");
                        }
                        else
                        {
                            Console.WriteLine("No numbers to calculate the average.");
                        }
                        break;

                    case "4": // Display All Numbers
                        Console.WriteLine("All numbers:");
                        foreach (var number in numbers)
                        {
                            Console.WriteLine(number);
                        }
                        break;

                    case "5": // Remove Number
                        Console.Write("Enter a number to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int numToRemove) && numbers.Contains(numToRemove))
                        {
                            numbers.Remove(numToRemove);
                            Console.WriteLine($"{numToRemove} has been removed.");
                        }
                        else
                        {
                            Console.WriteLine("Number not found or invalid input.");
                        }
                        break;

                    case "6": // Exit
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }

            Console.WriteLine("Application ended. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
