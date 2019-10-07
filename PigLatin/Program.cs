using System;
using System.Collections.Generic;
namespace PigLatin{
    class Program{
        public static void toPigLatin(string input){
            if (input == null) return; //returns nothing for null input
            input = input.ToLower();
            string[] words = input.Split();
            char[] toMod;
            List<string> result = new List<string>();            
            foreach (string word in words){
                if (word.Equals(" ") || word.Equals("")) continue;
                toMod = word.ToCharArray();
                //vowel
                if(toMod[0] == 'a'||toMod[0] == 'e'|toMod[0] == 'i'||toMod[0] == 'o'||toMod[0] == 'u'){
                    result.Add(word + "ay");
                }
                //consonant
                else{
                    result.Add(word.Substring(1) + word.Substring(0, 1) + "ay");
                }
            }
            //print
            foreach (string word in result){
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args){
            Console.WriteLine("Pig Latin\n");
            //Use a Regex to handle punctuation
            Console.WriteLine("The apple is very blue, and it disturbs me.");
            toPigLatin("The apple is very blue, and it disturbs me.");
            Console.WriteLine();
            Console.WriteLine("The cat             likes to eat pinto beans");
            toPigLatin("The cat             likes to eat pinto beans");
            Console.WriteLine();
            Console.WriteLine("null");
            toPigLatin(null);
            Console.WriteLine();
            Console.WriteLine("5 spaces");
            toPigLatin("     ");
        }
    }
}
