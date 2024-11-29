using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FirstProject
{
    internal class BankAccount
    {
        public string AccountNumber;
        public string AccountHolder;
        public decimal Balance;
        public int AccountID;

        public BankAccount(string accountNumber, string accountHolder, decimal balance, int accountID)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
            AccountID = accountID;
        }
            
            


    }
}
