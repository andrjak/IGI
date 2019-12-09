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
        const int friendCount = 3;
        UserManager<User> _userManager;
        ApplicationContext _context;
        IHostingEnvironment _appEnvironment;

        public FriendController(UserManager<User> userManager, ApplicationContext context, IHostingEnvironment appEnvironment)
        {
            _userManager = userManager;
            _context = context;
            _appEnvironment = appEnvironment;
        }

        [HttpGet]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> FriendList(int pageNumber = 0)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("~/Views/Shared/_Friend.cshtml", await getFriendList(pageNumber));
                //return View(userFollower.Intersect(userFollowing).Skip(pageNumber * friendCount).Take(friendCount).ToList());
            }
            else return View(await getFriendList(pageNumber));
            //return View(userFollower.Intersect(userFollowing).ToList());
        }

        private async Task<List<User>> getFriendList(int pageNumber)
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            // Подписчики на user 
            var userFollower = _context.Follows.Where(var => var.FollowingId == user.Id).Select(var => var.Follower);
            // Подписки user
            var userFollowing = _context.Follows.Where(var => var.FollowerId == user.Id).Select(var => var.Following);
            return userFollower.Intersect(userFollowing).Skip(pageNumber * friendCount).Take(friendCount).ToList();
        }

        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> FindFriends()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            var allUser = _userManager.Users.ToList();
            // Подписки user
            var userFollowing = _context.Follows.Where(var => var.FollowerId == user.Id).Select(var => var.Following);
            var result = allUser.Except(userFollowing).ToList();
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
                if (user.Followings == null)
                    user.Followings = new List<Follow>();
                if (friend.Followers == null)
                    friend.Followers = new List<Follow>();
                var follow = new Follow(user, friend);
                _context.Follows.Add(follow);
                _context.Users.Find(user.Id).Followings.Add(follow);
                _context.Users.Find(friend.Id).Followers.Add(follow);

                var result1 = await _userManager.UpdateAsync(user);
                var result2 = await _userManager.UpdateAsync(friend);
                if (result1.Succeeded && result2.Succeeded)
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction("FindFriends");
                }
                else
                {
                    return NotFound();
                }
            }
            else return NotFound();
        }

        [HttpGet]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> DeleteFriend(string id)
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            User friend = await _userManager.FindByIdAsync(id);

            if (friend != null && user != null)
            {
                var follow = _context.Follows.Where(t =>t.FollowerId == user.Id && t.FollowingId == friend.Id).ToList();
                _context.Follows.Remove(follow[0]);
                _context.Users.Find(user.Id).Followings.Remove(follow[0]);
                _context.Users.Find(friend.Id).Followers.Remove(follow[0]);

                var result1 = await _userManager.UpdateAsync(user);
                var result2 = await _userManager.UpdateAsync(friend);
                if (result1.Succeeded && result2.Succeeded)
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction("FriendList");
                }
                else
                {
                    return NotFound();
                }
            }
            else return NotFound();
        }

        [Route("Followers")]
        [Route("FollowersList")]
        [Authorize(Roles = "admin, user")]
        public IActionResult FollowersList() { return View(); }

        [Route("Following")]
        [Route("FollowingList")]
        [Authorize(Roles = "admin, user")]
        public IActionResult FollowingList() { return View(); }
    }
}