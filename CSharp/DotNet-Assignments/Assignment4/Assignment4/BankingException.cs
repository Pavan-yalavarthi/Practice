using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
     class BankingException
    {
        public int accountNo;
        public int amount;
        public int balance;
        public String transaction_type, customer_name, account_type;

        public void DepositMoney()
        {
            Console.WriteLine("Enter the money to be deposit:");
            amount = Convert.ToInt32(Console.ReadLine());

        }
        public void WithDraw()
        {
            Console.WriteLine("Enter the money to be withdrawn:");
            amount = Convert.ToInt32(Console.ReadLine());

        }
        public void Balance()
        {
            Console.WriteLine("Enter the transaction type :: Deposit or Withdraw:");
            transaction_type = Console.ReadLine();
            if (transaction_type == "Deposit")
            {
                //  DepositMoney();
                balance = balance + amount;
                Console.WriteLine("The available balance is:" + balance);
            }
            else if (transaction_type == "WithDraw")
            {
                // WithDraw();
                balance = balance - amount;
                Console.WriteLine("The available balance is:" + balance);
            }

        }

        /* void Debit(int amount)
         {

             if (amount > balance)
             {

                 Console.WriteLine("Insufficient amount:");

             }
             else
             {
                 balance = balance - amount;

                 Console.WriteLine("The amount" + amount + "withdrawn successfully:");

             }

         }
         void Credit(int amount)
         {
             balance = balance + amount;

             Console.WriteLine("The amount" + amount + "deposited successfully:");
         }*/
    }
    class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException(string message) : base(message) { }
        static void Main(string[] args)
        {
            BankingException b = new BankingException();
            b.DepositMoney();
            b.WithDraw();
            b.Balance();
            try
            {
                if (b.amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive.");
                }
                if (b.amount > b.balance)
                {
                    throw new InsufficientBalanceException("Insufficient balance for withdrawal.");
                }

                b.balance -= b.amount;
                Console.WriteLine($"Withdrawn: {b.amount}. New Balance: {b.balance}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.Read();
        }
    }
}

