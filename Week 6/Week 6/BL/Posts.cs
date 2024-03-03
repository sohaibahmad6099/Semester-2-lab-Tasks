using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.BL
{
    internal class Posts
    {
        private List<string> Comments = new List<string>();
        private string Post;
        private int Likes=0;
        public Posts() { }
        public Posts( string post)
        {
            Post = post;
        }

        public void SetComments(string Comments)
        {
            this.Comments.Add(Comments);
        }
        public void SetLikes(int num)
        {
            Likes = Likes + num;
        } 
        public List<string> GetComm()
        {
            return Comments;
        }
        public string GetComment(int num)
        {
            return Comments[num];
        }
        public string GetPost() 
        {
            return Post;
        }
        public int GetLikes()
        {
            return Likes; 
        }
    }
}