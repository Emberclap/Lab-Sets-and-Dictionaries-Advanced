using System;
namespace Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> counts = new Dictionary<double, int>();
            foreach (double value in values)
            {
                if (!counts.ContainsKey(value))
                {
                    counts.Add(value, 0);
                }
                
                counts[value]++;
            }
            foreach (var value in counts)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }
        }
    }
}