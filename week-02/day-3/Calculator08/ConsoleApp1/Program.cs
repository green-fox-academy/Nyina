using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type in the expression:");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');



            string operat = inputArray[0];
            //char operat = Convert.ToChar(inputArray[0]);
            int number1 = Convert.ToInt32(inputArray[1]);
            int number2 = Convert.ToInt32(inputArray[2]);

            int result = 0;
            if (operat == "+")
            {
                result = number1 + number2;
            }
            if (operat == "-" )
            {
                result = number1 - number2;
            }
            if (operat == "*")
            {
                result = number1 * number2;
            }
            if (operat == "/")
            {
                result = number1 / number2;
            }
            if (operat == "%")
            {
                result = number1 % number2;
            }

            Console.WriteLine(result);
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
    }
}
