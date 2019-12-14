using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[5];
            for (int k = 0; k < 5; k++)
            {
                mas[0] = Convert.ToInt32(Console.ReadLine());
                mas[1] = Convert.ToInt32(Console.ReadLine());
                mas[2] = Convert.ToInt32(Console.ReadLine());
                mas[3] = Convert.ToInt32(Console.ReadLine());
                mas[4] = Convert.ToInt32(Console.ReadLine());
                {
                    break;
                }
            }
            int sum = 0;
            int n = 0;
            for (int i = 0; i < 5; i++)
            {
                if (mas[i] % 5 == 0)
                {
                    sum = sum + mas[i];
                }
                if (mas[i] % 5 == 0)
                {
                    n++;
                }
            }
            Console.WriteLine("Количество чисел, делящихся на '5' равно {0}", n);
            Console.WriteLine("\n Сумма чисел делящихся на '5' равна {0}", sum);
        }
    }
}

