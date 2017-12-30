using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Bank
    {
        List<BankAccount> bankAccount = new List<BankAccount>();

        // It should have a getAllMoney method, which returns the sum of
        // the accounts' money (sum of Currency values regardless of the Currency type).

        public void CreateAccount(BankAccount firstBankAccount)
        {
            bankAccount.Add(firstBankAccount);
        }

        int sum = 0;
        public int GetAllMoney()
        {
            foreach (var bankAccountElement in bankAccount)
            {
                sum += currency.value;
            }
            return sum;
        }
    }
}
