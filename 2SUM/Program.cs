using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       foreach (int i in pair_sum_sorted_array(new List<int> { 1}, 6))
        {
            Console.WriteLine(i);
        }

       Console.ReadKey();
    }

    public static List<int> pair_sum_sorted_array(List<int> numbers, int target)
    {
        // Write your code here.
        List<int> sol = new List<int>();

        if (numbers == null || numbers.Count < 2)
        {
            return sol;
        }

        int left = 0;
        int right = numbers.Count - 1;

        while (left < right)
        {
            int currentSum = numbers[left] + numbers[right];
            if (currentSum == target)
            {
                sol.Add(numbers[left]);
                sol.Add(numbers[right]);
                return sol;
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

        return sol;
    }
}