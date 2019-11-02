using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dados.Interfaces;
using Dados.Login;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        ILoginData _loginData;
        public HomeController(ILoginData loginData)
        {
            _loginData = loginData;
        }
        public IActionResult Index()
        {
            string teste = _loginData.TestaConexao();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
