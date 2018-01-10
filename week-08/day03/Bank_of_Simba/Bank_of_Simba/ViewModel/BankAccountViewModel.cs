using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank_of_Simba.Model;

namespace Bank_of_Simba.ViewModel
{
    public class BankAccountViewModel
    {
        public List<BankAccount> BankAccountList { get; set; } = new List<BankAccount>();

        public BankAccountViewModel()
        {
            AddToList();
        }

        private void AddToList()
        {
            BankAccountList.Add(new BankAccount()
            {
                Name = "Simba",
                Balance = "2000",
                AnimalType = "Animal.Lion",
            });

        }
    }
}
