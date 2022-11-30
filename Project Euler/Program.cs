using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            int Summa = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Summa += i;
                }
            }

            Console.WriteLine(Summa);
        }
    }
}
