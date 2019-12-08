using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewSocialNetwork.Data;
using NewSocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSocialNetwork.Components
{
    public class FollowersViewComponent : ViewComponent
    {
        private UserManager<User> _userManager;
        private ApplicationContext _context;

        public FollowersViewComponent(UserManager<User> userManager, ApplicationContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);  
            return View(_context.Follows.Where(var => var.FollowingId == user.Id).Select(var => var.Follower).ToList());
        }
    }
}
