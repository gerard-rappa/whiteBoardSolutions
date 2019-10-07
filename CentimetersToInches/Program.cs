using System;

namespace CentimetersToInches
{    
    class Program
    {
        public static void CmToIn(double cm)
        {
            float inches = (float)cm/(float)2.54;
            int feet = (int)inches / 12;
            inches -= feet * 12;
            Console.WriteLine(cm + " cm is "+feet + "\' " + inches + "\"");
        }
        static void Main(string[] args)
        {
            CmToIn(2.54);
        }
    }
}
