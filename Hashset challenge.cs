using System;
using System.Collections.Generic;

class HashSet
{
    public static int GetUniqueAbsoluteValuesCount(int[] A)
    {
        HashSet<int> abNumbers = new HashSet<int>();

        for (int i = 0; i < A.Length; i++)
        {
            abNumbers.Add(Math.Abs(A[i]));
        }

        return abNumbers.Count;
    }

    static void Main()
    {
        int[] exampleArray = { -1, -2, 3, 2, -3, 4 };

        int uniqueCount = GetUniqueAbsoluteValuesCount(exampleArray);

        Console.WriteLine($"Number of unique absolute values: {uniqueCount}");
    }
}