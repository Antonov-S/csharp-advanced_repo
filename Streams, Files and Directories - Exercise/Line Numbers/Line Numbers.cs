using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            string[] newLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int countOfLetters = CountOfLetters(line);
                int countOfMarks = CountOfPuncMarks(line);

                newLines[i] = $"Line {i + 1}: {lines[i]} ({countOfLetters})({countOfMarks})";
            }

            File.AppendAllLines("../../../output.txt", newLines);
        }

        static int CountOfLetters(string line)
        {
            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (char.IsLetter(currentSymbol))
                {
                    counter++;
                }
            }
            return counter;
        }

        static int CountOfPuncMarks(string line)
        {
            char[] punctuationMarks = { '-', ',', '.', '!', '?', '\'' };
            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];

                if (punctuationMarks.Contains(currentSymbol))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
