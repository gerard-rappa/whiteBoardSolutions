using System;
using System.Text.RegularExpressions;

namespace FindSubstring
{
    public class Program
    {
        public static int IndexOfSubstring(string str, string subStr)
        {
            if (str == null || subStr == null) return -1;
            if (str.Length == 0 || subStr.Length == 0) return -1;
            Regex rx = new Regex(subStr);

            Match m = rx.Match(str);
            int ret = Convert.ToInt32(m.Index.ToString());

            if (Match.Empty != m)
            {
                return ret;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IndexOfSubstring("Mississippi", null));
            Console.WriteLine(IndexOfSubstring("Mississippi", ""));
            Console.WriteLine(IndexOfSubstring("Mississippi", "mIssIssIPpi"));
            Console.WriteLine(IndexOfSubstring("Mississippi", "issip"));
            Console.WriteLine(IndexOfSubstring("Mississippi", "Mississippi"));
        }
    }
}
