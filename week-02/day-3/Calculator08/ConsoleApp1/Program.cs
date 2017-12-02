using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type in the expression:");
            var input = new StringBuilder(operator, num1, num2);
            Console.ReadLine(input);
            int num1 = num1.ToInt32;



            int result.Operation


            Console.ReadLine();

            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit
        }
        
        static void Operation(char operator, int num1, int num2)
        {
            if (char operator = "+")
            {
                int result = num1 + num2;
            }
            if (operator = "-" )
            {
                int result = num1 - num2;
            }
            if (operator = "*")
            {
                result = num1 * num2;
            }
            if (operator = "/")
            {
                result = num1 / num2;
            }
            if (operator = "%")
            {
                result = num1 % num2;
            }
            Console.WriteLine(result);
        }
    }
}
