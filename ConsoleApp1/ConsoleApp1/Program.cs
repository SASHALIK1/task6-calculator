using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            {

                Console.Write("Введіть перший операнд: ");
                int operandOne = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть другий операнд: ");
                int operandTwo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть операцію (+, -, *, /): ");
                char operation = Convert.ToChar(Console.ReadLine());


                switch (operation)
                {
                    case '+':
                        Add(operandOne, operandTwo);
                        break;
                    case '-':
                        Sub(operandOne, operandTwo);
                        break;
                    case '*':
                        Mul(operandOne, operandTwo);
                        break;
                    case '/':
                        Div(operandOne, operandTwo);
                        break;
                    default:
                        Console.WriteLine("Невірна операція. Введіть правильний знак (+, -, *, /).");
                        break;
                }

                Console.ReadLine();
            }

            void Add(int operandOne, int operandTwo)
            {
                
            }

            void Sub(int operandOne, int operandTwo)
            {
                
            }

            void Mul(int operandOne, int operandTwo)
            {
                
            }

            void Div(int operandOne, int operandTwo)
            {
                
            }
        }
    }
    
}
