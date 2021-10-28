using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mywishes = new List<string>();
            mywishes.Add("new phone");
            mywishes.Add("new shoes");
            mywishes.Add("new shirt");
            mywishes.Add("new keyboard");

            //Console.WriteLine($"There are {mywishes.Count} items on your wishlist.");

            //Console.WriteLine(mywishes[0]);
           // Console.WriteLine(mywishes[mywishes.Count - 1]);

            foreach(string wish in mywishes)
            {
                Console.WriteLine($"item on your wishlist; {wish}");
            }
            Console.WriteLine();

            Console.WriteLine("enter a wish;");
            string userwish = Console.ReadLine();

            mywishes.Add(userwish);

            foreach (string wish in mywishes)
            {
                Console.WriteLine($"item on your wishlist; {wish}");
            }
        }
    }
}
