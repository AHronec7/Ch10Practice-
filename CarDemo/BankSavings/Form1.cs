using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSavings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Getaccount(Account account)
        {
            // Temporary variables to hold interest and balance
            decimal interestrate;
            decimal balance;

            // get the account number
            account.Accountnumber = AccountBox.Text;

            // get the maturity date
            account.Maturitydate = MaturityBox.Text;

            // get the interest rate
            if (decimal.TryParse(InterestBox.Text, out interestrate))
            {
                account.Interestrate = interestrate;

                // get the balance.. // have to parse

                if (decimal.TryParse(BalanceBox.Text, out balance))
                {
                    account.Balance = balance;
                }
                else
                {
                    MessageBox.Show("invalid balance");
                }
            }
            else
            {
                MessageBox.Show("invalid interest rate");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account myaccount = new Account();

            Getaccount(myaccount);

            AccountNumberBox.Text = myaccount.Accountnumber;
            InterestRateBox.Text = myaccount.Interestrate.ToString("n2");
            TotalBalanceBox.Text = myaccount.Balance.ToString("c");
            MaturityDateBox.Text = myaccount.Maturitydate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
