namespace codewars.Exercises;

public class ReduceButGrow
{
    public static int Grow(int[] x)
    {
        int multiplier = 1;
        for (int i = 0; i < x.Length; i++)
        {
            multiplier *= x[i];
        }

        return multiplier;
    }
}

// [3, 4, 5] = 3 * 5 * 5 = 60