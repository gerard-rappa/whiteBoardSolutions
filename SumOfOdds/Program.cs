using System;

namespace SumOfOdds{
    public class Program{
        public static int SumOfOdds(int x){
            int result = 0;
            for (int i = 1; i <= x; i+=2){
                result += i;
            }
            return result;
        }
        public static void Main(string[] args){
            Console.WriteLine("Sum Of Odds");
        }
    }
}
