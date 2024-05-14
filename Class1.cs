using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Class2
    {
        static void Third(string[] args)
        {
            Console.WriteLine("Enter numbers to sum. Enter -1 to stop.");

            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number: ");
                int input = int.Parse(Console.ReadLine());

                // Sentinel value to stop the loop
                if (input == -1)
                {
                    break;
                }

                sum += input;  // Add input to sum
            }

            Console.WriteLine($"The total sum of entered numbers is: {sum}");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

