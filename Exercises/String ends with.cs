namespace codewars.Exercises;

public class String_ends_with
{
    public static bool Solution(string str, string ending)
    {
        if (str.Length >= ending.Length)
        {

            static string ReverseString(string input)
            {
                string output = "";
                for (int i = input.Length; i > 0; i--)
                {
                    output += input[i - 1];
                }

                return output;
            }

            string strrev = ReverseString(str);
            string samelength = "";

            for (int i = 0; i < ending.Length; i++)
            {
                samelength += strrev[i];
            }

            if (ReverseString(samelength) == ending)
            {
                return true;
            }
        }
        return false;
    }
}

// str.EndsWith(ending);

