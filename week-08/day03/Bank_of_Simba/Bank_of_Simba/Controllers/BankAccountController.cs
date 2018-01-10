using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bank_of_Simba.Model;
using Bank_of_Simba.ViewModel;

namespace Bank_of_Simba.Controllers
{
    [Route("")]
    public class BankAccountController : Controller
    {
        //Az osztály 1 példányát hozom létre és ezt adom a View-hoz (lentebb)
        public static BankAccountViewModel bankAccountVM = new BankAccountViewModel();

        [HttpGet("Simba")]
        public IActionResult Index()
        {
            return View(bankAccountVM);
        }

        [HttpPost("Simba")]
        public IActionResult AddBalance()
        {
            //A view modellen belül van a lista és az in utánival tudok rá hivatkozni
            //(a fenti példány.BankAccountViewModell-ben szereplő lista neve:
            foreach (var bankAccListElement in bankAccountVM.BankAccountList)
            {
                if (bankAccListElement.Owner.Equals("King"))
                {
                    bankAccListElement.Balance += 100;
                }
                else
                {
                    bankAccListElement.Balance += 10;
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost("add")]
        public IActionResult AddPerson(BankAccount bankAccount)
        {
            bankAccountVM.BankAccountList.Add(bankAccount);
            return RedirectToAction("Index");
        }

    }
}
