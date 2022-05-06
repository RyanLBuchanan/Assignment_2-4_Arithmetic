using System;

namespace Assignment_2_4_Arithmetic
{
    class Addition
    {
        // Main method begins execution of C# app
        static void Main()
        {
            // Declare variables
            int number1;
            int number2;
            int sum;

            // Prompt user
            Console.WriteLine("Enter first integer: ");
            // Read first integer from user
            number1 = int.Parse(Console.ReadLine());

            // Prompt user
            Console.WriteLine("Enter second integer: ");
            // Read second integer from user
            number2 = int.Parse(Console.ReadLine());

            // Sum integers
            sum = number1 + number2;

            // Display sum
            Console.WriteLine($"Sum is {sum}");
        } // End Main
    } // End Class Addition
}
