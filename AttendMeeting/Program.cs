using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        //create intervals
        List<List<int>> intervals = new List<List<int>>
        {
            new List<int> { 0, 30 },
            new List<int> { 5, 10 },
            new List<int> { 6, 20 }
        };
        //check if can attend all meetings
        int result = can_attend_all_meetings(intervals);
        Console.WriteLine(result);
        //create another set of intervals
        List<List<int>> intervals2 = new List<List<int>>
        {
            new List<int> { 2, 4 },
            new List<int> { 6, 10 }
        };
        //check if can attend all meetings
        int result2 = can_attend_all_meetings(intervals2);
        Console.WriteLine(result2);
        Console.ReadKey();
    }

    public static int can_attend_all_meetings(List<List<int>> intervals)
    {
        intervals.Sort((x, y) => x[0].CompareTo(y[0]));
        int i = 0;
        int j = 1;

        if (intervals == null || intervals.Count < 2)
        {
            return 1; // If there are no meetings or only one, you can attend all.
        }

        foreach (List<int> interval in intervals)
        {
            if (interval.Count != 2 || interval[0] >= interval[1])
            {
                return 0; // Invalid interval, cannot attend all meetings.
            }

            if (i < intervals.Count - 1)
            {
                if (intervals[i][1] > intervals[j][0])
                {
                    return 0; // Overlapping intervals, cannot attend all meetings.
                }
            }
            i++;
            j++;
            

        }


        return 1;
    }

}