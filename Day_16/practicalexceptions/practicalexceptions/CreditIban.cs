using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalexceptions
{
    internal class CreditIban : IBAN
    {
        public decimal CreditLimit { get; set; }
        public CreditIban(string ibannum, string accountholdername, decimal accountammount, decimal creditLimit)
            : base(ibannum, accountholdername, accountammount)
        {
            CreditLimit = creditLimit;
        }
        public void deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("invalid amount input");
            }
            AccountAmount += amount;
            Console.WriteLine($"Credited {amount} , new balance {AccountAmount}");
        }
        public void withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("invalid amount input");
            }
            if (AccountAmount - amount <= -CreditLimit)
            {
                throw new InvalidCreditIbanException("not enough money to withdraw amount - credit");
            }
            AccountAmount -= amount;
        }

        public override string ToString()
        {
            return $"ibannum : {IBANNum} , accountholdername : {AccountHolderName} , accountamunt : {AccountAmount} , creditlimit : {CreditLimit}";
        }
    }
}
