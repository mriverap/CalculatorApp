using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Select operation ('+','-','*','/'): ");
                var op = Console.ReadLine();
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                float result;
                var calc = new Calculator();
                switch (op)
                {
                    case "+":
                        result = calc.Add(a, b);
                        break;
                    case "-":
                        result = calc.Subtract(a, b);
                        break;
                    case "*":
                        result = calc.Multiply(a, b);
                        break;
                    case "/":
                        result = calc.Divide(a, b);
                        break;
                    default:
                        result = 0;
                        break;
                }
                Console.Write($"{a} {op} {b} = {result}");
                Console.WriteLine("\nEnd of calculation (type 'q' to end):");
                var q = Console.ReadLine();
                if (q == "q")
                {
                    break;
                }
            }

            Console.WriteLine("Good bye!");
        }
    }
}
