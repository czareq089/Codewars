namespace codewars.Exercises;
using System.Collections.Generic;

public class Multiples_of_3_or_5
{
    public static int Solution(int value)
    {
        int sum = 0;
        List<int> multiples = new List<int>();
        for (int i = 0; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                multiples.Add(i);
            }
        }
        foreach (var item in multiples)
        {
            sum += item;
        }
        if (value > 0)
        {
            return sum;
        }
        return 0;
    }
}