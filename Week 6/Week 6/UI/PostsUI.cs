using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.UI
{
    internal class PostsUI
    {
        public static void Menu()
        {
            Console.WriteLine("1. Add Person");
            Console.WriteLine("2. Remove Person");
            Console.WriteLine("3. Add Post");
            Console.WriteLine("4. Remove Post");
            Console.WriteLine("5. Add Comment");
        }
        public static int Id()
        {
            int id ;
            Console.WriteLine("Enter the Id of the Person: ");
            id = int.Parse(Console.ReadLine()) ;
            return id ;
        }
        public static string Name() 
        {
            string name;
            Console.WriteLine("Enter your UserName: ");
            name = Console.ReadLine() ;
            return name ;
        }
        public static string Description() 
        {
            string description;
            Console.WriteLine("Enter your Comment: ");
            description = Console.ReadLine() ;
            return description ;
        }
        public static string Post()
        {
            string description;
            Console.WriteLine("Enter your post: ");
            description = Console.ReadLine();
            return description;
        }
    }
}
