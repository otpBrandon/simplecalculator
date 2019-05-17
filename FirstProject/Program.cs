using System;

namespace FirstProject
{
    class Program
    {
        public class Operations
        {
            // TESTING COMMITS AGAIN
            // Addition method
            public int GetSum(int num1, int num2)
            {
                return num1 + num2;
            }
            // Subtraction method
            public int GetSub(int num1, int num2)
            {
                return num1 - num2;
            }
            // Multiplication method
            public int GetProd(int num1, int num2)
            {
                return num1 * num2;
            }
            // Division method
            public double GetDiv(double div1, double div2)
            {
                return div1 / div2;
            }

            // Consolidated case method
            public void Run()
            {
                char selectNumber = '0';
                int num1;
                int num2;

                // Calculator main menu
                Console.WriteLine("Welcome to this simple calculator.\n" +
                    "Enter:\n" +
                    "1. for addition (+)\n" +
                    "2. for subtraction (-)\n" +
                    "3. for multiplication (x)\n" +
                    "4. for division (÷)\n" +
                    "5. to Exit\n");

                Operations ops = new Operations(); // Instantiate Operations object for function calls

                try // Handle user input errors during main menu selection
                {
                    selectNumber = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! Invalid operation selection.\n{0}", e.Message);
                    Console.WriteLine("Please try your selection again.\n");
                    Run();
                }
                finally
                {
                    // Operation switch
                    switch (selectNumber)
                    {
                        case '1': // Addition
                            Console.WriteLine("Enter first number to add: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter second number to add: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("{0} + {1} = {2}", num1, num2, ops.GetSum(num1, num2));
                            Console.WriteLine("Press any key to continue:\n");
                            Console.ReadLine();
                            Run();
                            break;
                        case '2': // Subtraction
                            Console.WriteLine("Enter number to subtract from: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter number to subtract: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("{0} - {1} = {2}", num1, num2, ops.GetSub(num1, num2));
                            Console.WriteLine("Press any key to continue:\n");
                            Console.ReadLine();
                            Run();
                            break;
                        case '3': // Multiplication
                            Console.WriteLine("Enter first number to multiply: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter second number to multiply: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("{0} x {1} = {2}", num1, num2, ops.GetProd(num1, num2));
                            Console.WriteLine("Press any key to continue:\n");
                            Console.ReadLine();
                            Run();
                            break;
                        case '4': // Division
                            Console.WriteLine("Enter number to divide: ");
                            double div1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter number to divide by: ");
                            double div2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0} ÷ {1} = {2}", div1, div2, ops.GetDiv(div1, div2));
                            Console.WriteLine("Press any key to continue:\n");
                            Console.ReadLine();
                            Run();
                            break;
                        case '5': // Exit application
                            Console.WriteLine("Thanks for using this simple calculator!\n");
                            Environment.Exit(0);
                            break;
                        default: // Invalid entry
                            Console.WriteLine("{0} is not a valid entry. Please enter a number [1 - 5].\n\n", selectNumber);
                            Run();
                            break;
                    }
                }
            }
            static void Main(string[] args)
            {
                Operations run = new Operations(); // Instantiate Operations object
                run.Run(); // Run it all
            }
        }
    }
}
