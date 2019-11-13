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

        //[Authorize(Roles = "admin, user")]
        //public IActionResult EditProfile() // Страница настроек пользователя
        //{
        //    return View();
        //}

        //[HttpPost]
        //[Authorize(Roles = "admin, user")]
        //public async Task<IActionResult> EditProfile(AdditionalSettingsViewModel model) 
        //{
        //    if (ModelState.IsValid)
        //    {
        //        User user = await _userManager.FindByNameAsync(User.Identity.Name);

        //        user.Name = model?.Name;
        //        user.Surname = model?.Surname;
        //        user.Country = model?.Country;
        //        user.Email = model?.Email;
        //        user.Birthday = model.Birthday;

        //        user.Activities = model?.Activities;
        //        user.FavoriteFilms = model?.FavoriteFilms;
        //        user.FavoriteGames = model?.FavoriteGames;
        //        user.Interests = model?.Interests;
        //        user.Languages = model?.Languages;

        //        var result = await _userManager.UpdateAsync(user);
        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            foreach (var error in result.Errors)
        //            {
        //                ModelState.AddModelError(string.Empty, error.Description);
        //            }
        //        }
        //    }
        //    return View();
        //}

        //[HttpPost]
        //[Authorize(Roles = "admin, user")]
        //public async Task<IActionResult> EditMainInfo(EditUserViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        User user = await _userManager.FindByNameAsync(User.Identity.Name);

        //        user.Name = model?.Name;
        //        user.Surname = model?.Surname;
        //        user.Country = model?.Country;
        //        user.Email = model?.Email;
        //        user.Birthday = model.Birthday;

        //        var result = await _userManager.UpdateAsync(user);
        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            foreach (var error in result.Errors)
        //            {
        //                ModelState.AddModelError(string.Empty, error.Description);
        //            }
        //        }
        //    }
        //    return View();
        //}

        //[HttpPost]
        //[Authorize(Roles = "admin, user")]
        //public async Task<IActionResult> AddPhoto(IFormFile uploadedFile)
        //{
        //    if (uploadedFile != null)
        //    {
        //        User user = await _userManager.FindByNameAsync(User.Identity.Name);

        //        if (user.ImagePath != null) // Если фото уже существует удаляем его 
        //        {
        //            FileInfo fileInf = new FileInfo(user.ImagePath);
        //            if (fileInf.Exists)
        //            {
        //                fileInf.Delete();
        //            }
        //        }
                
        //        string path = "/Photos/" + uploadedFile.FileName; // путь к папке Files
        //        // сохраняем файл в папку Files в каталоге wwwroot
        //        using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
        //        {
        //            await uploadedFile.CopyToAsync(fileStream);
        //        }
        //        user.ImagePath = path;
        //        user.ImageName = uploadedFile.FileName;
        //        _context.SaveChanges();
        //    }

        //    return RedirectToAction("Index");
        //}

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

        [Authorize(Roles = "admin, user")]
        public IActionResult MessageList()
        {
            ViewData["Message"] = "Your messages.";

            return View();
        }

        [HttpGet]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> AddFrend(string id)
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
