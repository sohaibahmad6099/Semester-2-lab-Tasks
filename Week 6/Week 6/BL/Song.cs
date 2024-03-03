using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.BL
{
    internal class Song
    {
        private string NameOfSong;
        private string Writer;
        private string Singer;
        public Song() { }
        public Song(string NameOfSong,string Writer,string Singer) 
        {
            this.NameOfSong = NameOfSong;
            this.Writer = Writer;
            this.Singer = Singer;
        }
        public void SetNameOfSong(string NameOfSong)
        {
            this.NameOfSong = NameOfSong;
        }
        public void SetWriter(string Writer) 
        {
            this.Writer = Writer;
        }
        public void SetSinger(string Singer) 
        {
            this.Singer = Singer;
        }
        public string GetSinger() 
        {
            return Singer;
        }
        public string GetWriter() 
        {
            return Writer;
        }
        public string GetNameOfSong()
        {
            return NameOfSong;
        }
    }
}
