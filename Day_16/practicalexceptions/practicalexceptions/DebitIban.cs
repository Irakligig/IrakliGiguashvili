using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalexceptions
{
    internal class DebitIban : IBAN
    {
        public DebitIban(string ibannum, string accountholdername, decimal accountammount) : base(ibannum, accountholdername, accountammount)
        {

        }
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new InvalidAmountException("invalid amount input");
            }
            AccountAmount += amount;
            Console.WriteLine($"deposited amount: {amount} , Total : {AccountAmount}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new InvalidAmountException("invalid amount input");
            }
            if (amount > AccountAmount)
            {
                throw new InvalidDebitIbanException("not enough money to withdraw - debit");
            }
            AccountAmount -= amount;
            Console.WriteLine($"withdrawn amount {amount} , total amount {AccountAmount}");
        }

        public override string ToString()
        {
            return ($"ibannum : {IBANNum} , accountholdername : {AccountHolderName} , accountamunt : {AccountAmount}");
        }
    }

    public class InvalidAmountException : Exception
    {
        public InvalidAmountException(string text) : base(text) { }
    }
    public class InvalidDebitIbanException : Exception
    {
        public InvalidDebitIbanException(string text) : base(text) { }
    }
    public class InvalidCreditIbanException : Exception 
    {
        public InvalidCreditIbanException(string text) : base(text) { }
    }

}
