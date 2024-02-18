using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_App.BL
{
    internal class Book
    {
        public Book(string name,int copies,int price) 
        { 
            this.name = name;
            this.copies = copies;
            this.price = price;
        }
        public string name;
        public int number;
        public int price;
        public int copies;
    }
}
