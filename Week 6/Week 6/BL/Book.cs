using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.BL
{
    internal class Book
    {
       private int Id;
       private string NameOfBook;
       private Author Author;

        public Book(int Id,string NameOfBook, Author Author) 
        {
            this.Id = Id;
            this.NameOfBook = NameOfBook;
            this.Author = Author;
        }
        public void SetId(int Id)
        {
           this.Id= Id;
        }
        public void SetNameOfBook(string NameOfBook) 
        {
            this.NameOfBook = NameOfBook;
        }
        public void SetAuthorOfBook(Author Author)
        {
            this.Author = Author;
        }
        public int GetId()
        {
            return Id;
        }
        public string GetNameOfBook()
        {
            return NameOfBook;
        }
        public Author GetAuthorOfBook()
        {
            return Author;
        }
        public Book() { }
    }
}
