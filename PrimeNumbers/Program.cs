using System;
using System.Threading;

namespace PrimeNumbers
{
    public class Program
    {
        public static bool isPrime(int x)
        {            
            if (x <= 1) return false;
            if (x % 2 == 0 && x != 2) return false;
            for (int i = 3; i <= Math.Sqrt(x); i+=2)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers!");
            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.WriteLine($"{i} is {isPrime(i)}");
                Thread.Sleep(200);
            }
        }
    }
}
