namespace codewars.Exercises;

public class Printer_Errors
{
    public static string PrinterError(String s)
    {
        char[] allowed_letters = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' };
        int errors = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (!allowed_letters.Contains(s[i]))
            {
                errors++;
            }
        }

        return $"{s.Length - errors}/{s.Length}";
    }
}
