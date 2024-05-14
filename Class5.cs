using System;

namespace Lesson_1
{
    class InfiniteLoopDemo
    {
        static void Main()
        {
            int counter = 0;

            // Infinite while loop
            while (true)
            {
                Console.WriteLine($"Counter: {counter}");
                counter++;  // Increment counter

                // Adding a delay so the output is readable
                System.Threading.Thread.Sleep(1000); // Sleep for 1000 milliseconds (1 second)
            }
        }
    }
}
