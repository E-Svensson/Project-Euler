using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 600851475143; // 600851475143

            List<int> primes = new List<int>();

            double sqrt = Math.Sqrt(num);

            for (int i = 2; i < sqrt; i++)
            {
                if (num % i == 0)
                {
                    num = num / i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
