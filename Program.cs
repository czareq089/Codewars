namespace codewars;
using System.IO;
using static Methods;
using Exercises;

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
                case "1": // planning to add this as pages in the future for better visibility
                    ListFiles();
                    break;
                case "2":
                    ShowProgress();
                    break;
                case "3":
                    Console.WriteLine();
                    CreateSkeleton();
                    break;
                case "4" or "" or "exit" or "c" or "e":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, try again!");
                    break;
            }
        }
    }




}