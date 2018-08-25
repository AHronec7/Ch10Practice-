using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSavings
{
    class Savings
    {
        private string accountnumber;
        private decimal interestrate;
        private decimal balance;

        // the constructor with backing fields
        public Savings()
        {
            accountnumber = "";
            interestrate = 0;
            balance = 0;

        }
        public string Accountnumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
        }
        public decimal Interestrate
        {
            get { return interestrate; }
            set { interestrate = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
