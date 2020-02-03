using System;
using System.Collections.Generic;


namespace Reverse_Polish_Notation
{
    class Program
    {
        static void Main(string[] args)
        {       
            string arg;
            Console.WriteLine("Enter a two numbers one after another with pushing 'Enter' after every num than enter an operation.\nAfter that type '=' and hit 'Enter' to procceed : ");
            Stack<double> RPN = new Stack<double>();

             while ((arg = Console.ReadLine()) != "end")
             {
                double num=0;
                bool isNum = double.TryParse(arg, out num);
                if (isNum)
                {                   
                    RPN.Push(num);
                }
                else
                {                    
                    double op2=0;                    
                    switch (arg)
                    {
                        case "+":
                            RPN.Push(RPN.Pop() + RPN.Pop());
                            break;
                        case "*":
                            RPN.Push(RPN.Pop() * RPN.Pop());
                            break;
                        case "-":
                            op2 = RPN.Pop();
                            RPN.Push(RPN.Pop() - op2);
                            break;
                        case "/":
                            op2 = RPN.Pop();
                            if (op2 != 0.0)
                            {
                                RPN.Push(RPN.Pop() / op2);
                            }
                            else
                            {
                                Console.WriteLine("You cannot divide by zero");
                            }
                            break;
                        case "=":
                            Console.WriteLine("Result: " + RPN.Pop());
                            break;
                        default:
                            Console.WriteLine("Error, try again");
                            break;
                    }
                }
             }
        }
    }
}

    