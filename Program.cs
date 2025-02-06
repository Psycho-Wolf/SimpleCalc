using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Calculator {
    class Program {
        static void Main(string[] args) {
            // Initialization
            Console.Title = "UwUnet";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("HeOwO! What would you like to calculate?");
            Console.ForegroundColor = ConsoleColor.White;
            
            double num1, num2, resultNum;
            bool contCalc = true;
            int count = 0;

            while (contCalc == true) {
                Console.Clear();
                Console.WriteLine("Loop #: " + count);
                Console.WriteLine("Lets do some math uwu");

                Console.WriteLine("Pick an operation: + - * /");
                string desiredOp = Console.ReadLine();

                Console.Write("Enter your first number: ");
                num1 =  Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your first number: ");
                num2 =  Convert.ToDouble(Console.ReadLine());
                
                switch (desiredOp) {
                    case "+":
                        resultNum = num1 + num2;
                        Console.WriteLine("The result is: " + resultNum);
                        break;
                    case "-":
                        resultNum = num1 - num2;
                        Console.WriteLine("The result is: " + resultNum);
                        break;
                    case "*":
                        resultNum = num1 * num2;
                        Console.WriteLine("The result is: " + resultNum);
                        break;
                    case "/":
                        resultNum = num1 / num2;
                        Console.WriteLine("The result is: " + resultNum);
                        break;
                    }             
                contCalc = MoreCalcs();
                count++;
            }

        }

        static bool MoreCalcs() {
            Console.WriteLine("Would you like to compute something again? (Y/N)");
            string contCalc = Console.ReadLine();

            switch (contCalc) {
                case "y":
                    return true;
                case "Y":
                    return true;
                case "n":
                    return false;
                case "N":
                    return false;
                default: 
                    return MoreCalcs();
            }
        }
           
    }
}