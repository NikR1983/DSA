using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       foreach (int i in pair_sum_sorted_array(new List<int> { 1,2,3,4,10}, 7))
        {
            Console.WriteLine(i);
        }

       Console.ReadKey();
    }

    /// <summary>
    /// Given a sorted array of integers and a target sum, this function finds a pair of numbers in the array that add up to the target sum.
    public static List<int> pair_sum_sorted_array(List<int> numbers, int target)
    {

        if (numbers == null || numbers.Count < 2)
        {
            return new List<int>();
        }

        int left = 0;
        int right = numbers.Count - 1;

        while (left < right)
        {
            int currentSum = numbers[left] + numbers[right];
            if (currentSum == target)
            {
                return new List<int> { numbers[left], numbers[right] }; //return pair of numbers that add up to target
            }
            else if (currentSum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return new List<int>(); ;
    }
}