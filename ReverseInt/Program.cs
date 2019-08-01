using System;

namespace ReverseInt{
    public class Program{
        public static int reverseInt(int number){
            int result = 0;
            bool negative = false;
            if (number < 0){
                number *= -1;
                negative = true;
            }
            while (number > 0){
                result += number % 10;
                number /= 10;
                if(number < 1){
                    if (negative == true) result *= -1;
                    return result;
                }
                result *= 10;
            }
            if (negative == true) result *= -1;
            return result;
        }
        static void Main(string[] args){
            Console.WriteLine("Reverse Int");
        }
    }
}
