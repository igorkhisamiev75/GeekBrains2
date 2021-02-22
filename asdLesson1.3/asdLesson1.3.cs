using System;

namespace asdLesson1._3
{
    class Program
    {
        /* 3. Реализуйте функцию вычисления числа Фибоначчи
            Требуется реализовать рекурсивную версию и версию без рекурсии (через цикл).
            Пример чисел Фибоначчи:
            F(0) = 0,
            F(1) = 1.
            Для остальных чисел:
            F(N) = F(N-2) + F(N-1).
            То есть для F(2) будет F(2) = F(0) + F(1) = 0 + 1 = 1. 
            F(3) будет F(3) = F(1) + F(2) = 1 + 1 = 2. 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер последовательности Фибоначи:");
            int n = Convert.ToInt32(Console.ReadLine());
            
            //рекурсивным способом
            static int Fibonachi(int n)
             {
                 if (n == 0 || n == 1)
                 {
                     return n;
                 }
                 else
                 {
                     return Fibonachi(n - 1) + Fibonachi(n - 2);
                 }
             }

             Console.WriteLine($"F{n} = {Fibonachi(n)} - вычсление рекурсивным способом");

            //через цикл
            int n1, n2;
            n1 = 1; 
            n2 = 1;
            int sum = 0;

            if (n==0||n==1)
            {
                sum = n;
            }
            else
            {
                int j = 2;
                while (j < n)
                {
                    sum = n1 + n2;
                    n1 = n2;
                    n2 = sum;
                    j++;
                }

            }

            Console.WriteLine($"F{n} = {sum} - вычисление через цикл");
            Console.ReadKey();

        }
    }
}
