using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2 };
            int Summa = 2;

            // num[0] = 1
            // num[1] = 2

            int toggleValue = (0 ^ 1);

            int a = 0;
            int b = 1;

            while (num[0] < 4000000 || num[1] < 4000000)
            {
                num[a] = num[a] + num[b];

                if (num[a] % 2 == 0)
                {
                    Summa += num[a];
                }

                a ^= toggleValue;
                b ^= toggleValue;
            }

            Console.WriteLine(Summa);
        }
    }
}
