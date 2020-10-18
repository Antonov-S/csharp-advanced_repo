using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputSongs = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Queue<string> songs = new Queue<string>(inputSongs);

            string command = Console.ReadLine();

            while (songs.Count > 0)
            {
                string[] splited = command.Split().ToArray();
                if (splited[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (splited[0] == "Add")
                {
                    string currentSongToAdd = command.Substring(4);
                    if (songs.Contains(currentSongToAdd))
                    {
                        Console.WriteLine($"{currentSongToAdd} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(currentSongToAdd);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
