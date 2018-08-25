using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSavings
{
    class Account : Savings // the account class inherits from the savings base class
    {
        private string maturitydate;

        public Account()
        {
            maturitydate = "";
        }
        public string Maturitydate
        {
            get { return maturitydate; }
            set { maturitydate = value; }
        }

    }
}
