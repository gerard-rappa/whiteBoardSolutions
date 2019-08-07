using System;

namespace ReverseInt{
    public class Program{
        public static int reverseInt(int number){
            int result = 0;           
            while (number != 0){
                result += number % 10;
                number /= 10;
                if(number == 0)return result;                
                result *= 10;
            }            
            return result;
        }
    }
}