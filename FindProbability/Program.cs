using System;

namespace FindProbability
{
    class Program
    {
        public static double FindProbability(int number)
        {
            double answer = 0;

            if (number < 2 || number > 12) return 0;
            for (int i = 1; i <= 6 ; i++)
            {
                for (int j = 0; j <= 6 ; j++)
                {
                    if (i + j == number) answer++;
                }
            }

            return answer/36;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindProbability(8));
        }
    }
}
