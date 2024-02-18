using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using Task_1_Week_3_Lab.BL;

namespace Task_1_Week_3_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1

            /*transactionDetails details = new transactionDetails();
            details.ProductName = "Bats";
            details.Amount = 100F;
            details.transactionID = 123;
            details.date = "23-12-2023";
            details.Time = "9:51 am";
            transactionDetails Copy = new transactionDetails(details);
            Copy.Amount = 90.85F;
            Copy.ProductName = "Rackets";
            Copy.transactionID = 234;
            Console.WriteLine(details.ProductName+"\t"+details.transactionID+"\t"+details.Amount+"\t"+details.date+"\t"+details.Time);
            Console.WriteLine(Copy.ProductName + "\t" + Copy.transactionID + "\t" + Copy.Amount + "\t" + Copy.date + "\t" + Copy.Time);
            */



            // task 2
            /* float result;
             char op;
            Console.WriteLine("Enter the operator uou want to perform +,/,-,*");
            op = char.Parse(Console.ReadLine());
            Calculator cal = new Calculator();
            if (op == '+')
            {
                result = cal.Add();
                Console.WriteLine(result);
            }
            else if(op=='/')
            {
                result = cal.Div();
                Console.WriteLine(result);
            }
            else if(op=='-')
            {
                result = cal.Sub();
                Console.WriteLine(result);
            }
            else if(op=='*')
            {
                 result = cal.Mul();
                Console.WriteLine(result);
            }*/



            // task 3
             /*ATM data = new ATM(50000);
             char op;
             int count;
             while (true)
             {
                 Console.WriteLine("If you want to deposit a value type 1\nIf you want to withdraw type 2\nIf you want to view history tyoe 3\nIf you want to check balance type 4");
                 op = char.Parse(Console.ReadLine());
                 if (op == '1')
                 {
                     Console.WriteLine("Enter the amount you want to Deposit: ");
                     data.value = float.Parse(Console.ReadLine());
                     data.Add();
                 }
                 else if (op == '2')
                 {
                     Console.WriteLine("Enter the amount you want to withdraw: ");
                     data.value = float.Parse(Console.ReadLine());
                     data.Withdrawal();
                 }
                 else if (op == '3')
                 {
                     count = data.historyCheck();
                     for (int i = 0; i < count; i++)
                     {
                         Console.WriteLine(data.history[i]);
                         //Console.WriteLine(2);
                     }
                 }
                 else if (op == '4')
                 {
                     data.CheckBalance();
                 }
             }*/
            Console.ReadKey();
        }
    }
}
