using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_6.BL;

namespace Week_6.UI
{
    internal class BookUI
    {
        public static int IdInput()
        {
            int Id;
            Console.WriteLine("Enter the Id of the Book: ");
            Id = int.Parse(Console.ReadLine());
            return Id;
        }
        public static string BookName()
        {
            string BookName;
            Console.WriteLine("Enter the name of the Book");
            BookName = Console.ReadLine();
            return BookName;
        }
        public static string AuthorName()
        {
            string Author;
            Console.WriteLine("Enter the name of the Author");
            Author = Console.ReadLine();
            return Author;
        }
        public static int IdRemove()
        {
            int Id;
            Console.WriteLine("Enter the Index of the Book: ");
            Id = int.Parse(Console.ReadLine());
            return Id;
        }
        public static int Age()
        {
            int Id;
            Console.WriteLine("Enter age of the Author: ");
            Id = int.Parse(Console.ReadLine());
            return Id;
        }
    }
}
