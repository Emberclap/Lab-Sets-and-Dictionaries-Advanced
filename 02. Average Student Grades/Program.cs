using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentGrade = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = tokens[0];
                decimal grade = decimal.Parse(tokens[1], CultureInfo.InvariantCulture);

                if (!studentGrade.ContainsKey(name))
                {
                    studentGrade.Add(name, new List<decimal> { });
                }
                studentGrade[name].Add(grade);
            }

            foreach (var student in studentGrade)
            {
                decimal averageGrade = student.Value.Average();
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(grade => $"{grade:f2}"))} (avg: {averageGrade:f2})");
            }
        }
    }
}