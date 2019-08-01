using System;

namespace oddTest{
    class Program{
        static bool oddTest(int x){
            return (x % 2 == 1 || x % 2 == -1);
        }
        static void Main(string[] args){
            Console.WriteLine("oddTest.Main()");
            for (int i = -14; i < 105; i++){
                Console.WriteLine($"{i} is odd: {oddTest(i)}");
            }
        }
    }
}