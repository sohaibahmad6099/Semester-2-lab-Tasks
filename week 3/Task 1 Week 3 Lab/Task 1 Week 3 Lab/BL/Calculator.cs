using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Week_3_Lab.BL
{
    internal class Calculator
    {
        float a, b;
        public Calculator()
        {
            Console.WriteLine("Enter two Numbers: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
        }
        public float Add() 
        {
            return a + b;
        }
        public float Sub() 
        {
            return a - b;
        }
        public float Mul() 
        {
            return a * b;
        }
        public float Div() 
        {
            return a / b;
        }
    }
}
