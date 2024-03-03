using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Week_6.BL;

namespace Week_6.DL
{
    internal class PostsDL
    {
        public static List<Person> persons = new List<Person>();
        public static void AddPerson(int Id,string Username,Posts post)
        {
            Person person = new Person(Id,Username,post);
            persons.Add(person);
        }
        public static void RemovePerson(int Id) 
        {
            persons.RemoveAt(Id);
        }
        public static void AddPost(int num,Posts post) 
        {
            persons[num].AddPost(post);
        }
        public static void RemovePost(int num,int num2)
        {
            persons[num].RemovePost(num2);
        }
        public static void AddLike(int num,int num2)
        {
            persons[num].AddLikes(num2);
        }
        public static void RemoveLike(int num,int num2)
        {
            persons[num].RemoveLikes(num2);
        }
        public static void AddComment(int num,int num2,string Comments)
        {
            persons[num].AddComments(num2,Comments);
        }
        public static void RemoveComment(int num,int num2,int num3)
        {
            persons[num].RemoveComments(num2, num3);
        }
        public static void DisplayData()
        {
            for (int i = 0; i < persons.Count; i++) 
            {
                Console.WriteLine($"{i}\t{persons[i].GetUserName()}");
                for(int j = 0; j < persons[i].GetPosts().Count; j++)
                {
                    Console.WriteLine($"{j}\t{persons[i].GetUserPo(j)}\t{persons[i].GetLikes(j)}");
                    for(int k = 0; k < persons[i].GetPosts().Count;k++)
                    {
                        
                        Console.WriteLine($"\t{persons[i].GetPost(j).GetComment(k)}");
                    }
                }
            }
        }
    }
}
