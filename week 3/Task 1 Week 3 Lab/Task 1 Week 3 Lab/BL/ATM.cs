using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Week_3_Lab.BL
{
    internal class ATM
    {
        public float amount = 0;;
        public float value;
        int count = 0;
        public string[] history = new string[100];
        public ATM(float bal) 
        {
            amount = bal ;
        }
        public void Add()
        {
            amount = amount + value;
            transactionHistory();        }
        public void Withdrawal()
        {
            value *= -1;
            amount = amount + value;
            transactionHistory();
        }
        public void CheckBalance()
        {
            Console.WriteLine($"Current balance: {amount} ");
        }
        public void transactionHistory()
        {
            if(value>0)
            {
                history[count] = $"Deposited: {value} \t Total balance: {amount}";
                count++;
            }
            if (value < 0) 
            {
                history[count] = $"withdrawed: {value} \t Total balance: {amount}";
                count++;
            }
        }
        public int historyCheck()
        {
            return count;
        }

    }
}
