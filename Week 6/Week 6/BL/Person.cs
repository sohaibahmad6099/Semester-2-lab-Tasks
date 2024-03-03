using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.BL
{
    internal class Person
    {
        private int Id;
        private string UserName;
        private List<Posts> Posts = new List<Posts>();
        public Person() { }
        public Person(int Id,string UserName,Posts Posts)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.Posts.Add(Posts);
        }
        public void AddComments(int num,string Comment)
        {
            Posts[num].SetComments(Comment);
        }
        public void RemoveComments(int num,int num2)
        {
            Posts[num].GetComm().RemoveAt(num2);
        }
        public void AddPost(Posts Post) 
        {
            Posts.Add(Post);
        }
        public void RemovePost(int Id) 
        {
            Posts.RemoveAt(Id); 
        }
        public void AddLikes(int num)
        {
            Posts[num].SetLikes(1);
        }
        public void RemoveLikes(int num)
        {
            Posts[num].SetLikes(-1);
        }
        public void SetName(string Name)
        {
            UserName = Name;
        }
        public void SetId(int Id) 
        {
            this.Id = Id;
        }
        public int GetLikes(int num)
        {
            return Posts[num].GetLikes();
        }
        public string GetUserPo(int num) 
        {
            return Posts[num].GetPost();
        }
        public string GetComments(int num)
        {
            return Posts[num].GetComment(num);
        }
        public string GetUserName() 
        {
            return UserName;
        }
        public List<Posts> GetPosts() 
        {
            return Posts;
        }
        public int GetId() 
        {
            return Id;
        }
        public Posts GetPost(int Id)
        {
            return Posts[Id];
        }

    }
}
