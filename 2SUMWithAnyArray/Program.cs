using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 7, 2, 3, 1, 4 };
        int target = 7;

        List<int> sorted_numbers = MergeSort(numbers);

        foreach (int i in pair_sum_sorted_array(sorted_numbers,target))
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }

    public static List<int> MergeSort(List<int> numbers)
    {
        if (numbers == null || numbers.Count <= 1)
        {
            return numbers;
        }
        
        int mid = numbers.Count / 2;

        List<int> left = MergeSort(numbers.GetRange(0, mid));
        List<int> right = MergeSort(numbers.GetRange(mid, numbers.Count - mid));

        return Merge(left, right);
    }

    public static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();
        int i = 0, j = 0;
        while (i < left.Count && j < right.Count)
        {
            if (left[i] <= right[j])
            {
                result.Add(left[i]);
                i++;
            }
            else
            {
                result.Add(right[j]);
                j++;
            }
        }
        while (i < left.Count)
        {
            result.Add(left[i]);
            i++;
        }
        while (j < right.Count)
        {
            result.Add(right[j]);
            j++;
        }
        return result;
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