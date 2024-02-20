using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace week_4_Tasks.BL
{
    internal class Book
    {
        public string Author;
        public List<string> Chapters;
        public bool Available;
        public int pages;
        public int Price;
        public int bookMark;
        public string YearOfPublish;
        
        public string Title;
        public string publisher;
        public string ISBN;
        public int stock;
        public List<String> NameOfArthur = new List<string>();
        public string[] AuthrName = new string[4];

        public Book()
        { }


    }
}
