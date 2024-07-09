namespace SearchingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int arr1Result = LinearSearch(arr1, 4);
            int maxValue = arr1.Max();
            int minValue = arr1.Min();
            Console.WriteLine(arr1Result);
            Console.WriteLine("The max value is: " + maxValue);
            Console.WriteLine("The min value is: " + minValue);

            Console.ReadKey();
        }

        public static int LinearSearch(int[] arrToSearch, int target)
        {

            for (int i = 0; i < arrToSearch.Length; i++)
            {
                if (arrToSearch[i] == target) return i;
            }

            return -1;
        }

        public static int BinarySearch(int[] arrToSearch, int target) 
        {
            int lower = 0;
            int upper = arrToSearch.Length - 1;
            
            while (upper > lower)
            {
                int mid = (lower  + upper) / 2;
                if (arrToSearch[mid] == target) return mid;
                else if (target < arrToSearch[mid])
                {
                    upper = mid - 1;
                }
                else
                {
                    lower = mid + 1;
                }
            }

            return -1;
        }
    }
}

