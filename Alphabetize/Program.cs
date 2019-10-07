using System;

namespace Alphabetize
{
     public class Program {

        //generates random value
        public static int randomValue(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }

        public static string Alphabetize(string input)
        {
            char[] toAlphabetizeArray = input.ToCharArray();
            quickSort(toAlphabetizeArray, 0, toAlphabetizeArray.Length - 1);
            input = new string(toAlphabetizeArray);
            return input;
        }

        //sorts array
        public static void quickSort(char[] array, int left, int right){
            //if left == right, then you are trying to sort 1 element
            if (left < right){
                //pick a random index and find its sorted position, then sort the left, and then sort the right
                int point = partition(array, left, right);
                //sort left of array[point]
                //if point is placed at array[0 or 1] then nothing to the left needs to be checked
                if (point > 1){
                    quickSort(array, left, point - 1);
                }
                //sort right of array[point]
                //if point is at array[length-1 or length] then right is sorted
                if (point < right-1){
                    quickSort(array, point + 1, right);
                }
            }
        }
        //helper method for quickSort
        private static int partition(char[] array, int left, int right){
            //select random index between left and right as pivot
            char pivot = array[randomValue(left, right+1)];
            //loop until pivot is in final position
            while (true){
                //move left pointer to the right until value >= pivot
                while (array[left] < pivot){
                    left++;
                }
                //move right pointer to the left until value <= pivot
                while (array[right] > pivot){
                    right--;
                }
                //if left != right (left should never be greater than right)
                //then value on left >= pivot and value on right <= pivot
                //they must be swapped unless they are equal
                if (left < right){                    
                    char temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    //left!=right but the values are the same
                    if (array[left] == array[right]) left++;
                }
                //left == right which means that the pivot point is in its final place
                else{
                    return left;
                }
            }
        }


        static void Main(string[] args){
            Console.WriteLine("Quick Sort!");

            string toAlphabetize = "Hello World";

            toAlphabetize = Alphabetize(toAlphabetize);
            
            Console.WriteLine(toAlphabetize);
        }        
    }
}
