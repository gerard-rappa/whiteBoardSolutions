using System;
using System.Linq;
namespace CamelCase{
    public class Program{
        public static string toCamel(string input){
            //trims spaces and all illegal chars (except backslash and single quote)
            char[] illegal = {' ', '`', '~', '!', '@', '#', '$', '%', '^', '&',
                              '*', '(', ')', '-', '_', '+', '=', ':', ';', '|',
                              '"', '<', '>', ',', '.', '/', '?', '\\', '\''};
            input = input.Trim(illegal);
            string result = "";
            //returns blank string if first character is a digit
            if (!string.IsNullOrEmpty(input)){
                if (char.IsDigit(input.First())){
                    return "";
                }
            }
            input = input.ToLower();//Turns every char lowercase
            //loops to first index of nonAlphaNumeric char, adds everything up to it to result, then trims input
            for (int i = 0; i < input.Length; i++){
                //remove first char if it's some weird Alt+[number] char
                if(!char.IsLetterOrDigit(input[0])){
                    input = input.Substring(1);
                    input = input.Trim();
                    i = 0;
                    continue;
                }
                if (input[i].Equals(' ') || !char.IsLetterOrDigit(input[i])){
                    input = input.First().ToString().ToUpper() + input.Substring(1);
                    result = result + input.Substring(0, i);
                    input = input.Substring(i + 1);
                    input = input.Trim(illegal);
                    i = 0;
                }
            }//uppercase final input if it isnt null and add to result            
            if (!string.IsNullOrEmpty(input) && char.IsLetterOrDigit(input.First())){
                result = result + input.First().ToString().ToUpper() + input.Substring(1);
            }//make first character lowercase            
            if (!string.IsNullOrEmpty(result)){
                result = result.First().ToString().ToLower() + result.Substring(1);
            }
            Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args){
            Console.WriteLine("camelCase!");
        }            
    }               
}
