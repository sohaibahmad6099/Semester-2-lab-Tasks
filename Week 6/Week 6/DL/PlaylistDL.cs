using System;
using System.Collections.Generic;
using Week_6.BL;

namespace Week_6.DL
{
    internal class PlaylistDL
    {
        public static List<Playlist> playlists = new List<Playlist>();
        public static void AddPlayList(string Name, string Name2,string Writer,string Singer)
        {
            Playlist playlist = new Playlist();
            playlist.NewPlayList(Name, Name2, Writer, Singer);
            playlists.Add(playlist);
        }
        public static void AddSong(int num, string Name2, string Writer, string Singer)
        {
            playlists[num].SetSongList(Name2,Writer,Singer);
        }
        public static void RemoveSong(int num, int num2)
        {
            playlists[num].RemoveSong(num2);
        }
        public static void DisplayPlaylists()
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                Console.WriteLine($"{i}\t{playlists[i].GetName()}");
            }
        }
        public static void DisplaySong(int num)
        {
            for (int j = 0; j < playlists[num].GetSongList().Count; j++)
            {
                Console.WriteLine($"\t{j}\t{playlists[num].GetSingleSong(j).GetNameOfSong()}\t{playlists[num].GetSingleSong(j).GetWriter()}\t{playlists[num].GetSingleSong(j).GetSinger()}");
            }

        }
        public static void DisplaySongs()
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                Console.WriteLine($"{i}\t{playlists[i].GetName()}");
                for (int j = 0; j < playlists[i].GetSongList().Count; j++)
                {
                    Console.WriteLine($"\t{j}\t{playlists[i].GetSingleSong(j).GetNameOfSong()}\t{playlists[i].GetSingleSong(j).GetWriter()}\t{playlists[i].GetSingleSong(j).GetSinger()}");
                }
            }
        }
    }
}
