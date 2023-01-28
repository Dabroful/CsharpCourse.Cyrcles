using System;
using System.Collections.Generic;

namespace CsharpCourse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>();
            int j;
            Console.WriteLine("введите числа");
            for (int i = 0; i < 5; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out j))
                {
                    Console.WriteLine("вы ввели не числа");
                }
                else
                {
                    numbers.Add(j);
                }
            }
            
            int sum = 0;
            int raznica = numbers[0];
            int proizvedenie = 1;
            for(int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Сумма чисел равна {sum}");
        
            int k = 0;
            while(k < 5)
            {
                raznica -= numbers[k];
                k++;
            }
            Console.WriteLine($"разница чисел равна {raznica}");

            int prod = 1;
            foreach (int value in numbers)
            {
                prod *= value;
            }
            Console.WriteLine($"произведение чисел равно {prod}");
           
        }
    }
}