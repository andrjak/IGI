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
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            var allUser = _userManager.Users.ToList();
            var result = allUser.Intersect(user.Friends).ToList();
            return View(result);
        }

        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> FindFriends()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            var allUser = _userManager.Users.ToList();
            var result = allUser.Except(user.Friends).ToList();
            result.Remove(user);
            return View(result);
        }

        [HttpGet]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> AddFriend(string id)
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            User friend = await _userManager.FindByIdAsync(id);

            if (friend != null && user != null)
            {
                user.Friends.Add(friend);
                var result = await _userManager.UpdateAsync(user);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("FindFriends");
        }
    }
}