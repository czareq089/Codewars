namespace codewars;
using System.IO;
abstract class Program
{
    static void Main()
    {
        bool flag = true;
        Console.Clear();
        Console.SetWindowSize(88, 28);
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random r = new Random();
        Array colors = Enum.GetValues((typeof(ConsoleColor)));
        Console.ForegroundColor = (ConsoleColor)colors.GetValue((r.Next(colors.Length)));
        Console.WriteLine("========================================================================================");
        Console.WriteLine("                            Welcome to my Codewars repository!");
        Console.WriteLine("========================================================================================");
        Console.WriteLine();
        Console.WriteLine("Here are the options for what you can do here:");
        Console.WriteLine();
        Console.WriteLine("1. List all of the exercises that I've solved (7 kyu+)");
        Console.WriteLine("2. Show the progress for C#");
        Console.WriteLine("3. Exit");
        while (flag)
        {
            Console.WriteLine();
            Console.Write(": ");
            string? choice = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    for (int i = 0; i < GetFileList().Count; i++)
                    {
                        if(i == 0){
                            Console.WriteLine("\u256d\t" + GetFileList()[0]);
                        }
                        else if (i != 0 && i < GetFileList().Count-1)
                        {
                            Console.WriteLine("\u22a6\t" + GetFileList()[i]);
                        }
                        else
                        {
                            Console.WriteLine("\u2570\t" + GetFileList()[GetFileList().Count-1]);
                        }
                    }
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

    public static List<string> GetFileList()
    {
        string pathToExercises = "Exercises";
        DirectoryInfo dir = new DirectoryInfo(pathToExercises);
        List<string> fileList = new List<string>();
        foreach (FileInfo fileInfo in dir.GetFiles())
        {
            fileList.Add((fileInfo.Name).Replace(".cs", "") + "                        " + fileInfo.CreationTime);
        }
        return fileList;
    }

    public static void ShowProgress()
    {
        double numberOfExercises = 1895; //updated on  27/06/24
        double numberOfFiles = 0;
        foreach (var file in GetFileList())
        {
            numberOfFiles++;
        }
        double progress = (numberOfFiles / numberOfExercises) * 100;
        Console.WriteLine("\t\t\t" + Math.Round(progress, 2, MidpointRounding.ToEven) + "%");
        Console.Write("[");
        for (int i = 0; i < 50; i++)
        {
            if (i < Math.Round(progress, MidpointRounding.ToEven)/2)
            {
                Console.Write("\u2592");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.Write("]");
        Console.WriteLine();
    }
}