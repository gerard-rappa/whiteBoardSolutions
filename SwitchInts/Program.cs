using System;

namespace SwitchInts{
    public class Program{
        public static string switchInts(int a, int b){
            b = a + b;
            a = b - a;
            b = b - a;
            return $"{a}, {b}";
        }
        static void Main(string[] args){
            Console.WriteLine("Switch Ints!");
            switchInts(-32, -3);
        }
    }
}
