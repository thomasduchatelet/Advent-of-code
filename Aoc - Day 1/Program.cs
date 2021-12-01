using System;

namespace Aoc___Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"input\input.txt");

            var amount = 0;

            for (int i = 1; i < lines.Length; i++){
                if (double.Parse(lines[i]) > double.Parse(lines[i - 1]))
                    amount++;
            }

            Console.WriteLine("Answer part 1: " + amount);

            amount = 0;

            for (int i = 0; i < lines.Length - 3; i++)
            {
                var sum1 = double.Parse(lines[i]) + double.Parse(lines[i + 1]) + double.Parse(lines[i + 2]);
                var sum2 = double.Parse(lines[i + 1]) + double.Parse(lines[i + 2]) + double.Parse(lines[i + 3]);
                if (sum2 > sum1)
                    amount++;
            }

            Console.WriteLine("Answer part 2: " + amount);
        }
    }
}
