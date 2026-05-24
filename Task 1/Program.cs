using System;
using System.Runtime.InteropServices;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Enter an Interger value: ");

            int num1 = int.Parse(Console.ReadLine());


            Console.Write("Enter an operator [ Subtract -, Plus +, Multiply * or Division / ]:  ");
            string oper = Console.ReadLine();

            Console.Write("Enter anothor interger value: ");
            int num2 = int.Parse(Console.ReadLine());

            if (oper == "+")
            {
                double calc = num1 + num2;
                Console.WriteLine("{0} plus {1} equals {2} ", num1, num2, calc);
            }

            else if (oper =="-")
            {
                double calc = num1 - num2;
                Console.WriteLine("{0} minus {1} equals {2} ", num1, num2, calc);
            }
            else if (oper =="*")
            {
                Console.WriteLine(num1  + " times " + num2 + " equals "+ num1*num2);
            }
            else if (oper =="/")
            {
                Console.WriteLine(num1  + " divided " + num2 + " equals "+ num1/num2);
            }

        }
    }
}

