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
            int product;
            int difference;
            int quotient;

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

            // Multiply integers
            product = number1 * number2;

            // Subtract integers
            difference = number1 - number2;

            // Divide numbers
            quotient = number1 / number2;

            // Display sum
            Console.WriteLine($"Sum = {sum}");

            // Display product
            Console.WriteLine($"Product = {product}");

            // Display sum
            Console.WriteLine($"Difference is {difference}");

            // Display sum
            Console.WriteLine($"Quotient is {quotient}");
        } // End Main
    } // End Class Addition
}
