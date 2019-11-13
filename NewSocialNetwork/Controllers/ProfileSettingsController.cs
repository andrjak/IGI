using System;
using System.Collections.Generic;
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

    public class ProfileSettingsController : Controller
    {
        UserManager<User> _userManager;
        ApplicationContext _context;
        IHostingEnvironment _appEnvironment;

        public ProfileSettingsController(UserManager<User> userManager, ApplicationContext context, IHostingEnvironment appEnvironment)
        {
            _userManager = userManager;
            _context = context;
            _appEnvironment = appEnvironment;
        }

        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> EditProfile() // Страница настроек пользователя
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return NotFound();
            }
            AdditionalSettingsViewModel model = new AdditionalSettingsViewModel
            {
                Name = user.Name,
                Surname = user.Surname,
                Country = user.Country,
                Email = user.Email,
                Birthday = user.Birthday,

                Activities = user.Activities,
                FavoriteFilms = user.FavoriteFilms,
                FavoriteGames = user.FavoriteGames,
                Interests = user.Interests,
                Languages = user.Languages
            };
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> EditProfile(AdditionalSettingsViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByNameAsync(User.Identity.Name);

                user.Name = model?.Name;
                user.Surname = model?.Surname;
                user.Country = model?.Country;
                user.Email = model?.Email;
                user.Birthday = model.Birthday;

                user.Activities = model?.Activities;
                user.FavoriteFilms = model?.FavoriteFilms;
                user.FavoriteGames = model?.FavoriteGames;
                user.Interests = model?.Interests;
                user.Languages = model?.Languages;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View();
        }

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

        [HttpPost]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> AddPhoto(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                User user = await _userManager.FindByNameAsync(User.Identity.Name);

                if (user.ImagePath != null) // Если фото уже существует удаляем его 
                {
                    FileInfo fileInf = new FileInfo(user.ImagePath);
                    if (fileInf.Exists)
                    {
                        fileInf.Delete();
                    }
                }

                string path = "/Photos/" + uploadedFile.FileName; // путь к папке Files
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                user.ImagePath = path;
                user.ImageName = uploadedFile.FileName;
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}