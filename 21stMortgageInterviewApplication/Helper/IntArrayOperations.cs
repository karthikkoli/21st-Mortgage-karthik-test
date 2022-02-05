using System;
using System.Collections.Generic;
using System.Text;

namespace _21stMortgageInterviewApplication.Helper
{
    public class IntArrayOperations
    {
        public static int FindLargeNumber(int[] arr)
        {
            int largestNumber = arr[0];
            for (int i = 1; i < arr.Length; i++)
            { 
                if (arr[i] > largestNumber)
                {
                    largestNumber = arr[i];
                }
            }
            ////Return the largest number
            return largestNumber;
        }

        public static int FindSumofOddNumbers(int[] arr)
        {
            int sumofOddNumbers = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2 != 0)
                {
                    sumofOddNumbers += arr[i];
                }
            }
            ////Return the sum of odd numbers
            return sumofOddNumbers;
        }

        public static int FindSumofEvenNumbers(int[] arr)
        {
            int sumofEvenNumbers = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumofEvenNumbers += arr[i];
                }
            }
            ////Return the sum of even numbers
            return sumofEvenNumbers;
        }

        public static bool IsPositive(int number)
        {
            if(number > 0)
            {
                return true;
            }
            return false;
        }
    }
}
