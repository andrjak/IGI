using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using NewSocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSocialNetwork.Hubs
{
    public class ChatHub : Hub
    {
        //private UserManager<User> _userManager;

        //public ChatHub(UserManager<User> userManager)
        //{
        //    _userManager = userManager;
        //}

        //public ChatHub()
        //{

        //}

        //[Authorize(Roles = "admin, user")]
        //public async Task Send(string message, string to)
        //{
        //    var userName = Context.User.Identity.Name;
        //    User Sender = await _userManager.FindByNameAsync(userName);
        //    var SenderName = Sender.Name + " " + Sender.Surname;

        //    if (Context.UserIdentifier != to) // если получатель и текущий пользователь не совпадают
        //        await Clients.User(Context.UserIdentifier).SendAsync("Receive", message, SenderName);
        //    await Clients.User(to).SendAsync("Receive", message, SenderName);
        //}

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

    }
}
