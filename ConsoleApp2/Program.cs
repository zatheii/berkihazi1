using System;
using System.Data;
using System.Net.Mime;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuecalculation = true;
            while (continuecalculation)
            {
                Console.Write("enter the first number: ");
                int firstNumber = GetValidNumber();
                Console.Write("enter the second number: ");
                int secondNumber = GetValidNumber();
                
                Console.Write("enter the operator: ");
                char m_operator = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                
                int result = 0;
                switch(m_operator)
                {
                    case '+':
                        result = firstNumber + secondNumber;
                        break;
                    case '-':
                        result = firstNumber - secondNumber;
                        break;
                    case '*':
                        result = firstNumber * secondNumber;
                        break;
                    case '/':
                        if (secondNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                        continue;
                        
                    
                }
                        
                Console.WriteLine(firstNumber +" "+ m_operator +" "+ secondNumber +" = "+  result);
                Console.WriteLine("Do you want to continue?");
                char response = Console.ReadKey().KeyChar;
                continuecalculation = response == 'y';
                if (!continuecalculation)
                {
                    Console.WriteLine("\nThanks for playing!");
                }
                
            }
            
        }

        static int GetValidNumber()
        {
            int a;
            if(!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Please enter a valid integer.");
            }
            return a;
        }
    }
}