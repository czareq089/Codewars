//--------------------------------------------------------------------------------------
                                    //Bit Counting
//--------------------------------------------------------------------------------------

namespace codewars.Exercises;

public class Bit_Counting
{ 
	public static string DecToBin(int dec)
	{
		if (dec is 0)
		{
			return "0";
		}
		string result = "";
		while (dec > 0)
		{
			result = dec % 2 + result;
			dec /= 2;
		}
		return result;
	}

	public static int CountBits(int n)
	{
		string bin = DecToBin(n);
		int sum = 0;
		foreach (var c in bin)
		{
			switch (c)
			{
				case '1':
					sum++;
					break;
			}
		}
		return sum;
	}
}

// Convert.ToString(n, 2);