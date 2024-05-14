using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Class1
    {
        static void Second(string[] args)
        {
            // Prompting user to enter a number
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Using a for loop to count from 0 to the entered number
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);  // Output the current count
            }

            // Wait for the user to press a key to close the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
