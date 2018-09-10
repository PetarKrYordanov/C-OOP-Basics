using System;

public class Song
{
    private string artistName;
    private string songName;
    private int songMinutes;
    private int songSeconds;

    public Song(string artistName, string songName, int minutes,int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.SongMinutes = minutes;
        this.SongSeconds = seconds;
    }
    public int SongSeconds
    {
        get { return songSeconds; }
        set
        {
            if (value<0|| value>59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }
            this.songSeconds = value;
        }
    }

    public int SongMinutes
    {
        get { return songMinutes; }
        set
        {
            if (value < 0 || value > 14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            this.songMinutes = value;
        }
    }


    public string ArtistName
    {
        get { return this.artistName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            this.artistName = value;
        }
    }
    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            this.songName = value;
        }
    }
    public int GetSongSeconds()
    {
        var result = this.SongSeconds + 60 * this.SongMinutes;
        return result;
    }
}