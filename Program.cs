namespace codewars;
using System.IO;
using static Methods;

internal static class Program
{
    private static void Main()
    {
        bool flag = true;
        Initialize();
        PrintWelcomeMessage();
        while (flag)
        {
            Console.WriteLine();
            Console.Write(": ");
            string? choice = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    ListFiles();
                    break;
                case "2":
                    ShowProgress();
                    break;
                case "3" or "":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, try again!");
                    break;
            }
        }
    }




}