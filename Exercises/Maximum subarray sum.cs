//--------------------------------------------------------------------------------------
                                //Maximum subarray sum
//--------------------------------------------------------------------------------------

namespace codewars.Exercises;

public class Maximum_subarray_sum
{
	public static int MaxSequence(int[] arr)
	{
		int maxmax = int.MinValue;
		int max = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			max += arr[i];
			if (maxmax < max)
			{
				maxmax = max;

				if (max < 0)
				{
					max = 0;
				}
			}
		}
		return maxmax < 0 ? 0 : maxmax;
	}
}

// got it working using Kadane's algorithm 
// https://en.wikipedia.org/wiki/Maximum_subarray_problem