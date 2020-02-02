using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    public class Song
    {
        public string PlayList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
    class Program
    {
        static void Main()
        {
            int songNumbers = int.Parse(Console.ReadLine());

            List<Song> songList = new List<Song>();

            for (int i = 0; i < songNumbers; i++)
            {
                string[] input = Console.ReadLine().Split("_");

                string playList = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();

                song.PlayList = playList;
                song.Name = name;
                song.Time = time;

                songList.Add(song);
            }

            string typeListToPrint = Console.ReadLine();

            if (typeListToPrint == "all")
            {
                foreach (var song in songList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else 
            {
                foreach (var song in songList)
                {
                    if (song.PlayList == typeListToPrint)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
