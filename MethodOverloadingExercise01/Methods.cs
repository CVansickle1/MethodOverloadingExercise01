using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExercise01
{
    internal class Methods
    {

        public static int GetInput()
        {
            bool numCheck;

            numCheck = int.TryParse(Console.ReadLine(), out int num);

            while (!numCheck)
            {
                Console.WriteLine("Please enter a number: ");
                numCheck = int.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }

        public static double GetDoubleInput()
        {
            bool numCheck;

            numCheck = double.TryParse(Console.ReadLine(), out double doubleNum);

            while (!numCheck)
            {
                Console.WriteLine("Please enter a number: ");
                numCheck = double.TryParse(Console.ReadLine(), out  doubleNum);
            }

            return doubleNum;
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        public static string Add(int amountOne, int amountTwo, bool isTrue)
        {
            amountTwo *= 5;
            var sum = amountOne + amountTwo;
            return (isTrue) ? $"Your total is {sum} dollars" : $"Your total is {sum} dollar";
        }
    }
}
