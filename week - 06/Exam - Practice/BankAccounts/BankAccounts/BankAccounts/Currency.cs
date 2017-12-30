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
        protected int value;

        public Currency(int value)
        {
            this.value = value;
        }


    }
}
