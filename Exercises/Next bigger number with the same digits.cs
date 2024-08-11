namespace codewars.Exercises;

public class Next_bigger_number_with_the_same_digits
{
    static int[] SortDigits(long n)
    {
        string nstring = n.ToString();
        int[] counts = new int[10];
        for (int i = 0; i < nstring.Length; i++)
        {
            for (int j = 0; j < counts.Length; j++)
            {
                if(nstring[i] == j.ToString()[0])
                {
                    counts[j]++;
                }
            }
        }
        return counts;
    }

    static int CountDigits(long n)
    {
        string nstring = n.ToString();
        int count = 0;
        foreach (var unused in nstring)
        {
            count++;
        }
        return count;
    }
  
  
    static long NextBiggerNumber(long n)
    {
        long result = -1;
        int[] t = SortDigits(n);
    
        for (int i = 0; i < t.Length; i++)
        {
            if(t[i] == CountDigits(n))
            {
                return -1;
            }
        }

        for (int i = (int)n+1; i < Math.Pow(10, SortDigits(n).Sum()); i++)
        {
            int[] sortedi = SortDigits(i);
            if(Enumerable.SequenceEqual(sortedi, t))
            {
                result = i;
                break;
            }
        }
        return result;
    }
}