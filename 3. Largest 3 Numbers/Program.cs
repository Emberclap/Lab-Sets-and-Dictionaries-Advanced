﻿namespace _3._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).OrderByDescending(s => s)
                .Take(3)
                .ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}