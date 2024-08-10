namespace codewars.Exercises;


public static partial class Kata
{
    public static string ToUnderscore(int str)
    {
        return str.ToString();
    }

    public static string ToUnderscore(string str)
    {
        string result = $"{str[0]}";
        for (int i = 1; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                result += $"_{str[i].ToString().ToLower()}";
            }
            else
            {
                result += str[i];
            }
        }

        return result.ToLower();
    }
}