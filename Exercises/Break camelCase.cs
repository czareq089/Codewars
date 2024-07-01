namespace codewars.Exercises;

public class Break_camelCase
{
    public static string BreakCamelCase(string str)
    {
        string output = "";

        foreach (var c in str)
        {
            if (char.IsLower(c))
            {
                output += c;
            }
            else
            {
                output += " " + c;
            }
        }
        return output;
    }
}