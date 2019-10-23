using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueChars
{
    public class Program
    {
        public static int UniqueChars(string input)
        {
            string uniques = "";
            foreach(char letter in input)
            {
                if (letter != ' ')
                {
                    if (uniques.Contains(letter)) continue;
                    uniques += letter;
                }                
            }
            return uniques.Length;
        }
    }
}
