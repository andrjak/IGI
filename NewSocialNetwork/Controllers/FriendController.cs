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
    public class FriendController : Controller
    {
        UserManager<User> _userManager;
        ApplicationContext _context;
        IHostingEnvironment _appEnvironment;

        public FriendController(UserManager<User> userManager, ApplicationContext context, IHostingEnvironment appEnvironment)
        {
            _userManager = userManager;
            _context = context;
            _appEnvironment = appEnvironment;
        }

        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> FriendList()
        {
            if (User.Identity.IsAuthenticated)
            {
                User user = await _userManager.FindByNameAsync(User.Identity.Name);
                return View(user);
            }
            return View();
        }

        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> FindFriends()
        {
            return View(_userManager.Users.ToList());
        }

        [HttpGet]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> AddFriend(string id)
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            User friend = await _userManager.FindByIdAsync(id);

            if (friend != null && user != null)
            {
                if (user.Friends == null)
                    user.Friends = new List<User>();
                user.Friends.Add(friend);
                var result = await _userManager.UpdateAsync(user);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("FindFriends");
        }
    }
}