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
                Balance = 2000.00,
                Currency = "Zebra",
                AnimalType = "Animal.Lion",
                Owner = "King",
                GuyType = true,
            });
            BankAccountList.Add(new BankAccount()
            {
                Name = "Timon",
                Balance = 1100.00,
                Currency = "Zebra",
                AnimalType = "Animal.Meerkat",
                Owner = "Timon",
                GuyType = false,
            });
            BankAccountList.Add(new BankAccount()
            {
                Name = "Pumbaa",
                Balance = 900.00,
                Currency = "Zebra",
                AnimalType = "Animal.Warthog",
                Owner = "Pumbaa",
                GuyType = true,
            });
            BankAccountList.Add(new BankAccount()
            {
                Name = "Nala",
                Balance = 2100.00,
                Currency = "Zebra",
                AnimalType = "Animal.Lion",
                Owner = "Nala",
                GuyType = true,
            });
            BankAccountList.Add(new BankAccount()
            {
                Name = "Rafiki",
                Balance = 2200.00,
                Currency = "Zebra",
                AnimalType = "Animal.Monkey",
                Owner = "Rafiki",
                GuyType = true,
            });
        }
    }
}
