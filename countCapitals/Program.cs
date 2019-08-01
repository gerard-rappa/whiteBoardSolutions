using System;

namespace CountCapitals{
    public class Program{
        public static int CountCapitals(string sentence){
            int count = 0;
            foreach(char letter in sentence){
                if (char.IsUpper(letter)){
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args){
            Console.WriteLine("Count Capitals");
        }
    }
}
