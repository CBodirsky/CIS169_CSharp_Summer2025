using BankAccount.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BankAccount.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.EndingBalance = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(BankAccount.Models.BankAccount model)
        {
            model.Withdraw();
            ViewBag.EndingBalance = model.Balance;
            return View(model);
        }
    }
}
