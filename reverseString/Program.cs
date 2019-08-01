using System;

namespace ReverseString{
    public class Program{
        public static string reverseString(string input){
            string result = "";
            if (input == null) return null;//input is null            
            for (int i = input.Length-1; i >= 0; i--){//any other case
                result += input[i];
            }
            return result;
        }
        static void Main(string[] args){
            Console.WriteLine(reverseString("Reverse String!"));
        }
    }
}