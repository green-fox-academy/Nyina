using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class BankAccount
    {
        protected string name;
        protected string pin;
        protected Currency currency;

        public BankAccount(string name, string pin, Currency currency)
        {
            this.name = name;
            this.pin = pin;
            this.currency = currency;
        }

        public int Deposit(int parameter)
        {
            if (parameter > 0)
            {
                currency.value += parameter;
            }
            return currency.value;
        }

        // Create a withdraw method with two parameters: a pin code and an amount.
        // It should check if the given pin is correct (equals with the original pin)
        // and the Currency's value is more than the amount parameter.
        // If so, subtract the amount from the Currency's value and return with the amount.
        // Otherwise don't modify the Currency's value and return with 0.

        public int Withdraw(string pinCode, int amount)
        {
            if (pinCode == pin && currency.value > amount)
            {
                amount = currency.value - amount;
            }
            else
            {
                amount = 0;
            }
            return amount;
        }
    }
}
