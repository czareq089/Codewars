namespace codewars.Exercises;

public static class VowelCount
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'};

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if(str[i] == vowels[j])
                {
                    vowelCount++;
                }
            }
        }
        
        return vowelCount;
    }

    public static void Execute()
    {
        Console.WriteLine("Enter a word:");
        Console.WriteLine();
        string str = Console.ReadLine();
        Console.WriteLine($"{str} has {GetVowelCount(str)} vowels");
    }
}