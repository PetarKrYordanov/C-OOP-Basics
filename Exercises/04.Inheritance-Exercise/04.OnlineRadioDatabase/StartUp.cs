using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Song> playlist = ReadSongInformation();
        PrintResult(playlist);
    }

    private static void PrintResult(List<Song> playlist)
    {
        var totalSeconds = 0;
        Console.WriteLine($"Songs added: {playlist.Count}");
        if (playlist.Count == 0)
        {
            Console.WriteLine($"Playlist length: 0h 0m 0s");
            return;
        }

        foreach (var song in playlist)
        {
            totalSeconds += song.GetSongSeconds();
        }

        var playlistLength = new int[3]; // h : mm: ss
        var index = playlistLength.Length - 1;
        while (totalSeconds > 0 && index >= 0)
        {
            playlistLength[index--] = (int)(totalSeconds % 60);
            totalSeconds /= 60;
        }

        Console.Write($"Playlist length: ");

        Console.WriteLine($"{playlistLength[0]}h {playlistLength[1]}m {playlistLength[2]}s");
    }

    public static List<Song> ReadSongInformation()
    {
        var songList = new List<Song>();
        var inputNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputNumber; i++)
        {
            try
            {
                var songArgs = Console.ReadLine()
                    .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (songArgs.Length!= 3)
                {
                    throw new ArgumentException("Invalid song.");
                }
                var songArtist = songArgs[0];
                var songName = songArgs[1];
                var duration = new List<int>(2);
                try
                {
                    duration = songArgs[2].Split(':')
                        .Select(int.Parse)
                        .ToList();
                }
                catch
                {
                    throw new ArgumentException("Invalid song length");
                }
                var currentSong = new Song(songArtist, songName, duration[0], duration[1]);
                songList.Add(currentSong);
                Console.WriteLine("Song added.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        return songList;
    }
}

