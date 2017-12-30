using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class UsaDollar : Currency
    {
        public UsaDollar(int value) : base (value)
        {
            code = "USD";
            centralBankName = "Federal Reserve System";
        }
    }
}
