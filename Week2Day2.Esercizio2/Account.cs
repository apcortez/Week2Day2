using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2.Esercizio2
{
    class Account
    {
        public int IdAccount { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public Account()
        {

        }

        public Account(int IdAccount, string AccountHolder, decimal Balance)
        {
            this.IdAccount = IdAccount;
            this.AccountHolder = AccountHolder;
            this.Balance = Balance;
        }
    }
}
