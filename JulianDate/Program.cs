using System;

namespace JulianDate
{
    public class Program
    {
        //Takes a month and day and returns its julian date
        //Does not account for leap years
        public static int getJulian(int month, int day)
        {
            if(month < 1 || month >12 || day < 1 || day > 31)
            {
                Console.WriteLine("Invalid date");
                return 0;
            }
            if (month == 2 && day > 28)
            {
                Console.WriteLine("Invalid date");
                return 0;
            }
            if (month == 4 && day > 30)
            {
                Console.WriteLine("Invalid date");
                return 0;
            }
            if (month == 6 && day > 30)
            {
                Console.WriteLine("Invalid date");
                return 0;
            }
            if (month == 9 && day > 30)
            {
                Console.WriteLine("Invalid date");
                return 0;
            }
            if (month == 11 && day > 30)
            {
                Console.WriteLine("Invalid date");
                return 0;
            }
            int julian = day;
            int[] months = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30};
            for (int i = 0 ; i < month ; i++)
            {
                julian += months[i];
            }
            return julian;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Julian Date");
            Console.WriteLine(getJulian(1, 3));
        }
    }
}
