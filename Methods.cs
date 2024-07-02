using codewars.Exercises;
using System.Reflection;
namespace codewars;

public static class Methods
{

    public static void Initialize()
    {
        Console.Clear();
        Console.SetWindowSize(88, 28);
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random r = new Random();
        Array colors = Enum.GetValues((typeof(ConsoleColor)));
        ConsoleColor color = (ConsoleColor)colors.GetValue((r.Next(colors.Length)));
        ConsoleColor[] nocontrast = [ConsoleColor.Black, ConsoleColor.Gray, ConsoleColor.DarkGray];
        Console.ForegroundColor = nocontrast.Contains(color) ? ConsoleColor.White : color;
    }

    public static void PrintWelcomeMessage()
    {
        Console.WriteLine(ReturnXChars(88, '='));
        Console.WriteLine("                            Welcome to my Codewars repository!");
        Console.WriteLine(ReturnXChars(88, '='));
        Console.WriteLine();
        Console.WriteLine("Here are the options for what you can do here:");
        Console.WriteLine();
        Console.WriteLine("1. List all of the exercises that I've solved (7 kyu+)");
        Console.WriteLine("2. Show the progress for C#");
        Console.WriteLine("3. Create a skeleton file for a new exercise");
        Console.WriteLine("4. Exit");
    }

    public static string ReturnXChars(int number, char character)
    {
        string output = "";
        for (int i = 0; i < number; i++)
        {
            output += character;
        }

        return output;
    }

    public static List<string> GetFileList()
    {
        string pathToExercises = "Exercises";
        DirectoryInfo dir = new DirectoryInfo(pathToExercises);
        List<string> fileList = new List<string>();
        FileInfo[] files = dir.GetFiles().OrderBy(x => x.CreationTime).Reverse().ToArray();
        foreach (FileInfo fileInfo in files)
        {
            int nameLength = fileInfo.Name.Length;
            fileList.Add(
                (fileInfo.Name).Replace(".cs", "") + ReturnXChars(55 - nameLength, ' ') + fileInfo.CreationTime);
        }

        return fileList;
    }

    public static void ListFiles()
    {
        for (int i = 0; i < GetFileList().Count; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("\u256d\t" + GetFileList()[0]);
            }
            else if (i != 0 && i < GetFileList().Count - 1)
            {
                Console.WriteLine("\u22a6\t" + GetFileList()[i]);
            }
            else
            {
                Console.WriteLine("\u2570\t" + GetFileList()[GetFileList().Count - 1]);
            }
        }
    }

    public static void ShowProgress()
    {
        double numberOfExercises = 1895; //updated on 27/06/24
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
            if (i < Math.Round(progress, MidpointRounding.ToEven) / 2)
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

    public static void CreateSkeleton()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Please enter the file name: (or type exit to cancel) ");
            Console.Write(": ");
            string name = Console.ReadLine();
            string pathToExercises = $"Exercises/{name}.cs";
            string scheme =
                $"//{ReturnXChars(86, '-')}\n{ReturnXChars(42 - name.Length / 2, ' ')}//{name}\n//{ReturnXChars(86, '-')}\n\nnamespace codewars.Exercises;\n\npublic class {name.Replace(' ', '_')}()\n";
            scheme += "{\n\tpublic static type ";
            scheme += $"{name.Replace(" ", "")}()\n";
            scheme += "\t{\n\t\n\t}\n}";
            if (name.Length > 0 && name != "exit")
            {
                File.AppendAllText(pathToExercises, scheme);
                Console.WriteLine("File created successfully!");
                flag = false;
            }
            else if (name == "exit")
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("The file name can not be empty, try again:\n");
            }
        }
    }
}