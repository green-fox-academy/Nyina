using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class HungarianForint : Currency
    {
        public HungarianForint(int value) : base (value)
        {
            code = "HUF";
            centralBankName = "Hungarian National Bank";
        }
    }
}
