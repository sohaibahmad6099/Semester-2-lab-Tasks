using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL
{
    internal class Teacher
    {
        public Teacher(string name, int password,int id) 
        {
            teacherid = id;
            teacherName = name;
            teacherPassword = password;
        }
        public Student(string name, int password, int id)
        {
           stuid = id;
            stuname = name;
            studentPassword = password;
        }
        public string stuname;
        public int stuid;
        public string teacherName; 
        public int teacherid;
        public string Coursename;
        public int Courseid;
        public int teacherPassword;
        public int studentPassword;


    }
}
