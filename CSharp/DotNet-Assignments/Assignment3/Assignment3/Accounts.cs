using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
   /* class Accounts
    {
        static int AccountNumber;
        static string CustomerName;
        static string AccountType;
        static double Balance;
        
        public Accounts(int accountNumber,string customerName,string accountType,double balance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            AccountType = accountType;
            Balance = balance;
        }
         void UpdateBalance(char transactionType, double amount)
        {
            if (transactionType == 'Deposit')
            {
                Credit(amount);
            }
            else
            {
                if (transactionType == 'Withdraw')
                {
                    Debit(amount);
                }
            }
        }
        void Debit()
        {
            if (transactionType == "Withdraw")
            {
                if (amount > balance)
                {
                    Console.WriteLine("Insufficient amount");
                }
                else
                {
                    balance = balance - amount;
                    Console.WriteLine(amount+" Withdraw successfully..");
                }
            }
        }
        void Credit()
        {
            if (transactionType == "Deposit")
            {
                balance = balance + amount;
                Console.WriteLine(amount+" Deposit succesfully..");
            }
        }
        void ShowData()
        {
            Console.WriteLine("Account Number is "+accountNumber);
            Console.WriteLine("Customer Name is "+customerName);
            Console.WriteLine("Account Type is "+accountType);
            Console.WriteLine("Transaction Type is "+transactionType);
            Console.WriteLine("Amount : "+amount);
            Console.WriteLine("Available Balance is : "+balance);
        }
        public static void Main(string[] args)
        {

        }
    }
}
