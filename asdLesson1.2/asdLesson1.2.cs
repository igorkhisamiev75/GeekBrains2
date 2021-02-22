﻿using System;

namespace asdLesson1._2
{
    class Program
    {
        /*2. Посчитайте сложность функции
            Вычислите асимптотическую сложность функции из примера ниже. 
            public static int  StrangeSum(int[] inputArray)
            {
               int sum = 0;
               for (int i = 0; i < inputArray.Length; i++)
               {
                   for (int j = 0; j < inputArray.Length; j++)
                   {
                       for (int k = 0; k < inputArray.Length; k++)
                       {
                           int y = 0;

                           if (j != 0)
                           {
                               y = k / j;
                           }

                           sum += inputArray[i] + i + k + j + y;
                       }
                   }
               }

               return sum;
            }
         */
        static void Main(string[] args)
        {
            
        
        }

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;

                        if (j != 0) //O(1)
                        {
                            y = k / j;      //O(1)
                        }

                        sum += inputArray[i] + i + k + j + y; 
                    }
                }
            }

            return sum;
        }
    }
}