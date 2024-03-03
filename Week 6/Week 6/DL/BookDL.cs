using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_6.BL;

namespace Week_6.DL
{
    internal class BookDL
    {
        public static List<Book> books = new List<Book>();
        public static void AddBook(int Id,string NameOfBook,Author AuthorOfBook)
        {
            books.Add(new Book(Id,NameOfBook,AuthorOfBook));
            Console.WriteLine(Id);
            Console.WriteLine(NameOfBook);
            Console.WriteLine(AuthorOfBook.GetName());
            Console.WriteLine(AuthorOfBook.GetAge());
        }
        public static void RemoveBook(int Id)
        {
            books.RemoveAt(Id);
        }
        public static void DisplayBook()
        {
            Console.WriteLine("Index\t");
            for (int i = 0;i<books.Count;i++)
            {
                Console.WriteLine($"{i}\t{books[i].GetId()}\t{books[i].GetNameOfBook()}\t{books[i].GetAuthorOfBook().GetName()}\t{books[i].GetAuthorOfBook().GetAge()}");
            }
        }
    }
}
