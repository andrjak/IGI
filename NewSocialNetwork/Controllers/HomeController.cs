using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewSocialNetwork.Models;

namespace NewSocialNetwork.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // Стартовая страница приложения 
        {
            return View();
        }

        public IActionResult FriendList()
        {
            ViewData["Message"] = "Your friends.";

            return View();
        }

        public IActionResult MessageList()
        {
            ViewData["Message"] = "Your messages.";

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
