using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalexceptions
{
    internal class User
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public CreditIban CreditAccount { get; set; }
        public DebitIban DebitAccount { get; set; }

        public User(string name , int idnumber , CreditIban creditaccount , DebitIban debitaccount)
        {
            Name = name;
            IdNumber = idnumber;
            CreditAccount = creditaccount;
            DebitAccount = debitaccount;
        }
        public void Display()
        {
            Console.Write($"name : {Name} , IdNumber : {IdNumber}");
            if (CreditAccount is not null)
            {
                Console.Write($"credit account : {CreditAccount.ToString()}");
            }
            if (DebitAccount is not null)
            {
                Console.Write($"credit account : {DebitAccount.ToString()}");
            }
        }
    }
}
