using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.BL
{
    internal class Author
    {
        private string AuthorOfBook;
        private int Age;
        public Author()
        { }
        public Author(string Name, int Age)
        {
            AuthorOfBook = Name;
            this.Age = Age;
        }
        public void SetName(string Name)
        {
            this.AuthorOfBook = Name;
        }
        public void SetAge(int Age)
        { 
            this.Age = Age; 
        }
        public string GetName()
        {
            return AuthorOfBook;
        }
        public int GetAge()
        { 
            return Age;
        }
    }
}
