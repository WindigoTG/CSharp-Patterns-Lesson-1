using System;

namespace CSharp_Patterns_Lesson_1_Olesov_M
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа\n");

            string userInput;
            int parsedInputResult;

            do
            {
                Console.WriteLine($"Пожалуйста, введите целое положительное число.\nВведите «q» для выхода");
                userInput = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(userInput, out parsedInputResult) && parsedInputResult > 0)
                {
                    GetFactorial(parsedInputResult);
                    GetSum(parsedInputResult);
                    GetMaxEven(parsedInputResult);
                    Console.WriteLine();
                }

            } while (userInput.ToLower() != "q");
        }

        private static void GetFactorial(int number)
        {
            int result = 1;
            if (number > 1)
                for (int i = 2; i <= number; i++)
                    result *= i;
            Console.WriteLine($"Факториал числа {number} равен {result}");
        }

        private static void GetSum(int number)
        {
            int result = 0;
            for (int i = 0; i <= number; i++)
                result += i;
            Console.WriteLine($"Сумма от 1 до {number} равна {result}");
        }

        private static void GetMaxEven(int number)
        {
            if (number > 2)
            {
                for (int i = number - 1; i > 1; i--)
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Максимальное четное число меньше {number} равно {i}");
                        return;
                    }
            }
            else
                Console.WriteLine($"Положительных четных чисел меньше {number} нет");
        }
    }
}
