using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewSocialNetwork.Data;
using NewSocialNetwork.Models;
using NewSocialNetwork.ViewModels;

namespace NewSocialNetwork.Controllers
{
    public class HomeController : Controller
    {
        UserManager<User> _userManager;
        ApplicationContext _context;
        IHostingEnvironment _appEnvironment;

        public HomeController(UserManager<User> userManager, ApplicationContext context, IHostingEnvironment appEnvironment)
        {
            _userManager = userManager;
            _context = context;
            _appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Index() // Стартовая страница приложения (Профиль пользователя)
        {
            if (User.Identity.IsAuthenticated)
            {
                User user = await _userManager.FindByNameAsync(User.Identity.Name);
                return View(user);
            }
            return View();
        }

        [Authorize(Roles = "admin, user")]
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
