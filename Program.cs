namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first operand:");
                double operand1;
                if (!double.TryParse(Console.ReadLine(), out operand1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Enter the second operand:");
                double operand2;
                if (!double.TryParse(Console.ReadLine(), out operand2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Choose the operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Modulo");
                Console.Write("Enter your choice (1-5): ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    continue;
                }

                double result = 0;
                switch (choice)
                {
                    case 1:
                        result = Add(operand1, operand2);
                        break;
                    case 2:
                        result = Subtract(operand1, operand2);
                        break;
                    case 3:
                        result = Multiply(operand1, operand2);
                        break;
                    case 4:
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Error! Division by zero.");
                            continue;
                        }
                        result = Divide(operand1, operand2);
                        break;
                    case 5:
                        result = Modulo((int)operand1, (int)operand2);
                        break;
                }

                Console.WriteLine($"Result: {result}\n");
            }

            static double Add(double a, double b)
            {
                return a + b;
            }

            static double Subtract(double a, double b)
            {
                return a - b;
            }

            static double Multiply(double a, double b)
            {
                return a * b;
            }

            static double Divide(double a, double b)
            {
                return a / b;
            }

            static int Modulo(int a, int b)
            {
                return a % b;
            }
        }
    }
}
