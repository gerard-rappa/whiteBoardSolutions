using System;

namespace Acronym
{
    public class Program
    {
        public static string GetAcronym(string input)
        {
            string[] arr = input.Split();
            string acronym = "";

            foreach(string word in arr)
            {
                if(word.Length>0) acronym += word[0];
            }

            return acronym.ToUpper();
        }
    }
}