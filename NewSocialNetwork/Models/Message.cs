using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewSocialNetwork.Models
{
    public class Message
    {
        public string Id { get; set; }
        [Required]
        public DateTime DateMessage { get; set; }
        [Required]
        public string TextMessage { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public Message() { }
        public Message(string message, User user)
        {
            TextMessage = message;
            User = user;
            UserId = user.Id;
            DateMessage = DateTime.Now;
        }
    }
}
