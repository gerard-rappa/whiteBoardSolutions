using System;

namespace QuickSort{
    public class Program {
        public static int randomValue(int min, int max){            
            Random r = new Random();
            return r.Next(min, max);            
        }
        //builds and returns an array with <size> elements and random values from 0-<maxVal>
        public static int[] randomArray(int size, int maxVal) {
            int[] array = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++) {
                array[i] = r.Next(maxVal);
            }
            return array;
        }
        //prints array
        public static void printArray(int[] array) {
            foreach (int item in array) {
                Console.WriteLine(item);
            }
        }
        //sorts array
        public static void quickSort(int[] array, int left, int right){
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
        private static int partition(int[] array, int left, int right){
            //select random index between left and right as pivot
            int pivot = array[randomValue(left, right+1)];
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
                    int temp = array[left];
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
            int[] array = randomArray(20, 1999);
            Console.WriteLine("Unsorted:");
            printArray(array);
            quickSort(array, 0, array.Length - 1);
            Console.WriteLine("\n\nSorted:");
            printArray(array);
        }        
    }
}
