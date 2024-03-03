using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.UI
{
    internal class PlayListUI
    {
        public static void Menu()
        {
            Console.WriteLine("1. Display Songs");
            Console.WriteLine("2. Remove Song");
            Console.WriteLine("3. Add Playlist");
            Console.WriteLine("4. Add Song");
            Console.WriteLine("5. Exit");
        }
        public static int Index()
        {
            int num;
            Console.WriteLine("Enter the index Number: ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        public static int IndexOfSong()
        {
            int num;
            Console.WriteLine("Enter the index Number of the Song: ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        public static string Name()
        {
            string Name;
            Console.WriteLine("Enter the Name: ");
            Name = Console.ReadLine();
            return Name;
        }
        public static string NameOfSong()
        {
            string Name;
            Console.WriteLine("Enter the Name of Song: ");
            Name = Console.ReadLine();
            return Name;
        }
        public static string NameOfPlaylist()
        {
            string Name;
            Console.WriteLine("Enter the Name of Playlist: ");
            Name = Console.ReadLine();
            return Name;
        }
        public static string Writer()
        {
            string Writer;
            Console.WriteLine("Enter the writer: ");
            Writer = Console.ReadLine();    
            return Writer;
        }
        public static string Singer()
        {
            string Writer;
            Console.WriteLine("Enter the Singer: ");
            Writer = Console.ReadLine();
            return Writer;
        }
    }
}
