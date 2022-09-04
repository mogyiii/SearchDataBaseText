using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        string searchText = "^b{1}.{4}9504@freemail.hu.{1,}";
        Regex rgx = new Regex(searchText);
        //string folderPath = System.Reflection.Assembly.GetEntryAssembly().Location;
        string folderPath = "D:\\Downloads\\Jelszavak\\";
        foreach (string file in Directory.GetFiles(folderPath, "*.txt", SearchOption.AllDirectories))
        {
            foreach (var line in File.ReadAllLines(file))
            {
                if (rgx.IsMatch(line))
                {
                    Console.WriteLine($"{line} {file}");
                }
            }
            
        }
    }
}