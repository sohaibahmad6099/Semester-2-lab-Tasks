using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4_Tasks.BL
{
    internal class Student
    {
        string Name;
        int RollNo;
        float Cgpa;
        int MatMark;
        int FscMark = 425;
        int EcatMark = 275;
        string hometown;
        bool IsHostelite;
        bool IsTakingScholarship;
        public float CalculateMerit()
        {
            float result;
            result = (FscMark * 60 / 495)  +(EcatMark * 40 / 400) ;
            return result;
        }
        public bool Scholarship(float merit)
        {
            if(merit>=80)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
