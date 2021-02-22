using System;

namespace asdLesson1._1
{
    class Program
    {
        /*1. Напишите на C# функцию согласно блок-схеме
        Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.
        Написать консольное приложение.
        Алгоритм реализовать отдельно в функции согласно блок-схеме.
        Написать проверочный код в main функции .
        Код выложить на GitHub.
        */
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            EasyOrHard(n);*/

            var testData = new TestCase[2];

            testData[0] = new TestCase()
            { 
                Input = 3, 
                Output = "простое"
            };

            testData[1] = new TestCase()
            {
                Input = 10, 
                Output = "не простое"
            };

        foreach(var testCase in testData)
            {
                string result = EasyOrHard(testCase.Input);
                Console.WriteLine($"для {testCase.Input} {testCase.Output}, а получилось {result}");
            }

    }

        private static string EasyOrHard(int n)
        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if ((n % i) == 0)
                {
                    d++;
                }
                i++;
            }

            if (d == 0)
            {
                Console.WriteLine($"{n} простое число {i}");
                return "простое";
            }
            else
            {
                Console.WriteLine($"{n} непростое число {i}");
                return "не простое";
            }
        }

        public class TestCase
        {
           public int Input { get; set; }
           public string Output { get; set; }
        }
    }
}
