using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalexceptions
{
    internal class IBAN
    {
        public string IBANNum { get; set; }
        public string AccountHolderName { get; set; }
        public decimal AccountAmount { get; set; }

        public IBAN(string ibannum , string accountholdername , decimal accountammount)
        {
            if (string.IsNullOrEmpty(ibannum) || ibannum.Length < 15) // amowmebs stringi null an carieli xoarari
            {
                // isrole exception
            }
            IBANNum = ibannum;
            AccountHolderName = accountholdername;
            AccountAmount = accountammount;
        }
    }
}
