using System;

namespace Aoc___Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"input\input.txt");

            var horizontal = 0;
            var depth = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Split(' ');
                var units = int.Parse(line[1]);
                switch (line[0])
                {
                    case "forward":
                        horizontal += units;
                        break;
                    case "up":
                        depth -= units;
                        break;
                    case "down":
                        depth += units;
                        break;
                }
            }

            Console.WriteLine("Answer part 1: " + (horizontal * depth));

            horizontal = 0;
            depth = 0;
            var aim = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Split(' ');
                var units = int.Parse(line[1]);
                switch (line[0])
                {
                    case "forward":
                        horizontal += units;
                        depth += (aim * units);
                        break;
                    case "up":
                        aim -= units;
                        break;
                    case "down":
                        aim += units;
                        break;
                }
            }

            Console.WriteLine("Answer part 2: " + (horizontal * depth));
        }
    }
}
