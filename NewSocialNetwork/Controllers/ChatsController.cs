using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewSocialNetwork.Data;
using NewSocialNetwork.Models;

namespace NewSocialNetwork.Controllers
{
    public class ChatsController : Controller
    {
        UserManager<User> _userManager;
        ApplicationContext _context;
        IHostingEnvironment _appEnvironment;
        User SelectedUser;

        public ChatsController(UserManager<User> userManager, ApplicationContext context, IHostingEnvironment appEnvironment)
        {
            _userManager = userManager;
            _context = context;
            _appEnvironment = appEnvironment;
        }

        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> SelectedChat(string id)
        {
            if (id != null)
            {
                var Recipient = await _userManager.FindByIdAsync(id);
                var Sender = await _userManager.FindByNameAsync(User.Identity.Name);
                SelectedUser = Recipient;
                return View(new List<User> { Recipient, Sender });
            }
            else return NotFound();
        }

        //[Authorize(Roles = "admin, user")]
        //public IActionResult getData()
        //{
        //    if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        //    {
        //        return View(SelectedUser.UserName);
        //    }
        //    return NotFound();
        //}

        [Authorize(Roles = "admin, user")]
        public IActionResult getMessage(string massage, string userName)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("~/Views/Shared/_Message.cshtml", (userName, massage));
            }
            return NotFound();
        }
    }
}