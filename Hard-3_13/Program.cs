using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] rnd_nums = new int[nums + 1];
            for (int i = 0; i < nums; i++)
            {
                rnd_nums[i] = i;
            }
            for (int i = 0; i < nums; i++)
            {
                for (int j = 2; j < rnd_nums[i]; j++)
                {
                    if (rnd_nums[i] % j == 0)
                    {
                        rnd_nums[i] = 0;
                    }
                }
            }

            string simple = "";
            int k = 0;
            for (int i = 0; i < nums; i++)
            {
                if (rnd_nums[i] > 1)
                {
                    k++;
                    simple += i.ToString() + ",";
                }
            }
            Console.WriteLine("Количество простых чисел= " + k.ToString() + "\n" + simple);
            Console.ReadKey();
        }
    }
}
