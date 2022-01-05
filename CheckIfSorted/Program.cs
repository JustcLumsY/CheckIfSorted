using System;

namespace CheckIfSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
           var result = IsSorted(numberArray);
            Console.WriteLine(result);
        }

        public static bool IsSorted(int[] numberArray)
        {
            int previousNumber = 0;
           
            
            for (int i = 0; i < numberArray.Length; i++)
            {
                int currentNumber = numberArray[i];
                if (i == 0)
                {
                    previousNumber = currentNumber;
                        continue;
                }
                if (previousNumber > currentNumber) return false;
                previousNumber = currentNumber;
            }
            return true;

        }
    }
}
