using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bank_of_Simba.Model;
using Bank_of_Simba.ViewModel;

namespace Bank_of_Simba.Controllers
{
    [Route("Simba")]
    public class BankAccountController : Controller
    {
        public static BankAccount BankAccount = new BankAccount();

    }
}
