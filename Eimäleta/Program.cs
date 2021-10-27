using System;
using System.IO;

namespace Eimäleta
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\wishlist";
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
   
            string fullfilePath = $@"{rootDirectory}\{fileName}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullfilePath);
            File.Create(fullfilePath);

            if (directoryExists && fileExists)
            {
                Console.WriteLine($"File {fileName} already exists in {rootDirectory}");
            }
            
            else if (!directoryExists)
            {
                Console.WriteLine($"wishList directory does not exists.");
                Directory.CreateDirectory(rootDirectory);

                File.Create(fullfilePath);
                Console.WriteLine($"File {fileName}.txt has been created.");

            }
            else
            {
                File.Create(fullfilePath);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }










































        }
    }
}
