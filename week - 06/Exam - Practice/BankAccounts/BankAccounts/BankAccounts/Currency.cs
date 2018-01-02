using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Currency
    {
        protected string code;
        protected string centralBankName;
        public int Value { get; set; }

        public Currency(int value)
        {
            this.Value = value;
        }
    }
}
