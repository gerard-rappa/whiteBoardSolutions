using System;

namespace minutesToAngles{
    public class Program{
        public static int clockAngle(int hour, int minute){
            int hourAngle = hour * 30;
            int minAngle = minute * 6;
            int result;
            if (hour == 12){
                hourAngle = 0;
            }
            if (hour > 6 && minute == 0){
                minAngle = 360;
            }
            if (hourAngle > minAngle){
                Console.WriteLine(hourAngle - minAngle);
                result = Math.Abs(Math.Abs(hourAngle - minAngle));
                if (result == 360) return 0;
                return result;
            }
            else{
                Console.WriteLine(Math.Abs(minAngle - hourAngle));
                result = Math.Abs(minAngle - hourAngle);
                if (result == 360) return 0;
                return result;
            }
        }
        static void Main(string[] args){
            Console.WriteLine("Minutes to angles");
        }
    }
}
