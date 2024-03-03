using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.BL
{
    internal class Playlist
    {
        private string Name;
        private List<Song> SongList= new List<Song>();
        public Playlist() { }
        public void NewPlayList(string Name,string Name2,string Writer,string Singer)
        {
            this.Name = Name;
            Song songs = new Song(Name2,Writer,Singer);    
            SongList.Add(songs);
        }
        public void SetName(string Name) 
        {
            this.Name = Name;
        }
        public void SetSongList(string Name2, string Writer, string Singer) 
        {
            Song songs = new Song(Name2, Writer, Singer);
            SongList.Add(songs);
        }
        public void RemoveSong(int num)
        {
            this.SongList[num] = null;
        }
        public string GetName() 
        {
            return Name;
        }
        public Song GetSingleSong(int num) 
        {
            return this.SongList[num];
        }
        public List<Song> GetSongList() 
        {
            return SongList;
        }
    }
}
