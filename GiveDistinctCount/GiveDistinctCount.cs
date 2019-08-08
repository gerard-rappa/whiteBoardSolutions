using System;
using QuickSort;

namespace GiveDistinctCount
{
    public class GiveDistinctCount
    {
        public static int getDistinctCount(int[] array)
        {
            int distinct = 0;
            Program.quickSort(array,0, array.Length-1);
            for (int i = 0; i < array.Length; i++)
            {
                while(i+1<array.Length && array[i]==array[i+1])
                {
                    i++;
                }
                distinct++;
            }
            return distinct;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Distinct Count!");
            //int[] array = Program.randomArray(10, 100);
            int[] array = {1,2,3,3,3,3,3};
            Program.printArray(array);
            Console.WriteLine("Distinct Count = "+getDistinctCount(array)); 
        }
    }
}
