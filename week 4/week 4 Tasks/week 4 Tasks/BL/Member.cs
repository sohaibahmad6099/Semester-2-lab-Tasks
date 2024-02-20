using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4_Tasks.BL
{
    internal class Member
    {
        public string Name;
        public string Member_ID;
        public List<string> books = new List<string>();
        public int Price;
        public int Num_of_Books;
        public int money_Spent;
        public int money_In_Bank;
        public Member() { }
    }
}
