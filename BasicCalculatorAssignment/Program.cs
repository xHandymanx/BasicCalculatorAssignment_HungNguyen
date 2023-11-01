namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code

        static void simplecalc()
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                // Task 1. Read choice input and assing it to new int variable

                int userchoice = Convert.ToInt32(Console.ReadLine());


                // Task 2. Check if user selected choice 5. If so then exit the loop
                if (userchoice == 5)
                {
                    break;
                }

                Console.Write("Enter first number: ");
                // Task 3. Get the first number and assing it to new double variable
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                // Task 4. Get the second number and assing it to new double variable
                double num2 = Convert.ToDouble(Console.ReadLine());
                // Task 5. Create double variable for default result value and assign it to be 0
                double result1 = 0;
                // Task 6. Handle choices using switch statement
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods
                switch (userchoice)
                {
                    case 1:
                        result1 = num1 + num2;
                        break;
                    case 2:
                        result1 = num1 - num2;
                        break;
                    case 3:
                        result1 = num1 * num2;
                        break;
                    case 4:
                        if (num2==0)
                        {
                            Console.WriteLine("2nd number cannot be 0");
                            break;
                        }
                        else
                        result1 = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }


                // Task 7. Print out the result
                Console.WriteLine(result1);
            }
        }


        // Declare your methods/functions here
        static void Main(string[] args)
        {
            simplecalc();
           //simplecalc();
        }
    }
}