using System;

namespace minutesToAngles
{
    public class Program
    {
        public static int clockAngle(int hour, int minute)
        {
            int hourAngle = hour * 30;
            int minAngle = minute * 6;
            if (hour == 12)
            {
                hourAngle = 0;
            }
            if (hour > 6 && minute == 0)
            {
                minAngle = 360;
            }
            if (hourAngle > minAngle)
            {
                Console.WriteLine(hourAngle - minAngle);
                return Math.Abs(Math.Abs(hourAngle - minAngle));
            }
            else
            {
                Console.WriteLine(Math.Abs(minAngle - hourAngle));
                return Math.Abs(minAngle - hourAngle);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Minutes to angles");
            clockAngle(12, 30);
        }
    }
}
