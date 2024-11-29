using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal Amount;
            int accountID;
            string Transaction;
            

            BankAccount Customer1 = new BankAccount("765432", "Yusuf Umar", 2500, 1);
            BankAccount Customer2 = new BankAccount("234567", "Halimah Umar", 1900, 2);
            BankAccount Customer3 = new BankAccount("145892", "Modupe Owodeyi", 3100, 3);
            BankAccount Customer4 = new BankAccount("594210", "Alani Owodeyi", 3400, 4);

           
            
            Console.Write("Enter Transaction: ");
            Transaction = Convert.ToString(Console.ReadLine());

            if (Transaction == "Deposit")
            {
                Console.Write("Amount: ");
                Amount = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter AccountID: ");
                accountID = Convert.ToInt32(Console.ReadLine());

                if (accountID == Customer1.AccountID)
                {
                    Console.WriteLine(Customer1.Balance + Amount);
                    Customer1.Balance = Convert.ToDecimal(Console.ReadLine());
                }
                else if (accountID == Customer2.AccountID)
                {
                    Console.WriteLine(Customer2.Balance + Amount);
                    Customer2.Balance = Convert.ToDecimal(Console.ReadLine());
                }
                else if (accountID == Customer3.AccountID)
                {
                    Console.WriteLine(Customer3.Balance + Amount);
                    Customer3.Balance = Convert.ToDecimal(Console.ReadLine());
                }
                else if (accountID == Customer4.AccountID)
                {
                    Console.WriteLine(Customer4.Balance + Amount);
                    Customer4.Balance = Convert.ToDecimal(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.ReadLine();



            }
            else if (Transaction == "Withdraw")
            {
                Console.Write("Amount: ");
                Amount = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter AccountID: ");
                accountID = Convert.ToInt32(Console.ReadLine());

                if (accountID == Customer1.AccountID && Customer1.Balance >= Amount)
                {
                    Console.WriteLine(Customer1.Balance - Amount);
                    Customer1.Balance = Convert.ToDecimal(Console.ReadLine());
                }
                else if (accountID == Customer2.AccountID && Customer2.Balance >= Amount)
                {
                    Console.WriteLine(Customer2.Balance - Amount);
                    Customer2.Balance = Convert.ToDecimal(Console.ReadLine());
                }
                else if (accountID == Customer3.AccountID && Customer3.Balance >= Amount)
                {
                    Console.WriteLine(Customer3.Balance - Amount);
                    Customer3.Balance = Convert.ToDecimal(Console.ReadLine());
                }
                else if (accountID == Customer4.AccountID && Customer4.Balance >= Amount)
                {
                    Console.WriteLine(Customer4.Balance - Amount);
                    Customer4.Balance = Convert.ToDecimal(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Insufficient Funds");
                }
                Console.ReadLine();

            }
            else if (Transaction == "Display Info")
            {
                Console.Write("Enter AccountID: ");
                accountID = Convert.ToInt32(Console.ReadLine());

                if (accountID == Customer1.AccountID)
                {
                    Console.WriteLine(Customer1.AccountNumber);
                    Console.WriteLine(Customer1.AccountHolder);
                    Console.WriteLine(Customer1.Balance);
                    

                }else if (accountID == Customer2.AccountID)
                {
                    Console.WriteLine(Customer2.AccountNumber);
                    Console.WriteLine(Customer2.AccountHolder);
                    Console.WriteLine(Customer2.Balance);
                    
                }
                else if (accountID == Customer3.AccountID)
                {
                    Console.WriteLine(Customer3.AccountNumber);
                    Console.WriteLine(Customer3.AccountHolder);
                    Console.WriteLine(Customer3.Balance);
                    
                }
                else if (accountID == Customer4.AccountID)
                {
                    Console.WriteLine(Customer4.AccountNumber);
                    Console.WriteLine(Customer4.AccountHolder);
                    Console.WriteLine(Customer4.Balance);
                    
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.ReadLine();

              

            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();



        }
      
    }
}
