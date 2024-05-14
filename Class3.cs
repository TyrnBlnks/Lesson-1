using System;

namespace Lesson_1
{
    class PasswordChecker
    {
        static void Fourth()
        {
            string correctPassword = "secret";
            string userInput;

            Console.WriteLine("Enter the password to continue.");

            // Initialize userInput to something other than the correct password
            userInput = "";

            // Use a while loop to ask for the password repeatedly until it is correct
            while (userInput != correctPassword)
            {
                Console.Write("Please enter your password: ");
                userInput = Console.ReadLine();

                // Check if the entered password is incorrect to provide feedback
                if (userInput != correctPassword)
                {
                    Console.WriteLine("Incorrect password, try again.");
                }
            }

            // User has entered the correct password
            Console.WriteLine("Correct password entered!");
            Console.WriteLine("You now have access to the system.");

            // Wait for the user to acknowledge before closing
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
