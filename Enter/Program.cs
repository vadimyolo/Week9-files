using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDiretory = @"C:\Users\opilane\Samples";

            Console.WriteLine("Enter Dyrectory name:");
            string userFolder = Console.ReadLine();

            string newDirectoryFullPath = @$"{rootDiretory}\{userFolder}";
            bool direstoryExists = Directory.Exists(newDirectoryFullPath);

            if (direstoryExists)
            {
                Console.WriteLine($"{userFolder} exists.");
                Console.WriteLine("Would you like to create a folder? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter file name:");
                    string userfile = Console.ReadLine() + ".txt";
                    string userFileFullPath = $@"{newDirectoryFullPath}\{userfile} ";
                    File.Create(userFileFullPath);


                }



            }
            else

            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userFolder} has been created.");
            }
        }
    }
}

