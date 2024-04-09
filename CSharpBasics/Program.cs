using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the simple calculator!");
            
            Console.WriteLine("Enter the first number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Enter the second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
     

            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            double result = 0;
            switch (choice)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"Result: {firstNumber} + {secondNumber} = {result}");
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"Result: {firstNumber} - {secondNumber} = {result}");
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"Result: {firstNumber} * {secondNumber} = {result}");
                    break;
                case 4:
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"Result: {firstNumber} / {secondNumber} = {result}");
                    break;

            }

        }
    }
}

    
