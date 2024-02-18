using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Week_3_Lab.BL
{
    internal class transactionDetails
    {
        public transactionDetails() 
        { }
        public transactionDetails(transactionDetails details) 
        {
            transactionID = details.transactionID;
            ProductName = details.ProductName;
            Amount = details.Amount;
            date = details.date;
            Time = details.Time;
        }
        public int transactionID;
        public string ProductName;
        public float Amount;
        public string date;
        public string Time;
    }
}
