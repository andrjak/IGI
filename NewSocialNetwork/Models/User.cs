using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NewSocialNetwork.Models
{
    public class User : IdentityUser
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }

        // personal information
        private ICollection<UserChat> chats;
        //private ICollection<Following> following;
        //private ICollection<Follower> followers;
        public virtual ICollection<Follow> Followings { get; set; }
        public virtual ICollection<Follow> Followers { get; set; }

        public virtual ICollection<UserChat> Chats
        {
            get
            {
                if (chats == null)
                    chats = new List<UserChat>();
                return chats;
            }
            set
            {
                if (value != null)
                    chats = value;
            }
        }

        public string ImagePath { get; set; }
        public string ImageName { get; set; }

        public string Languages { get; set; }
        public string Interests { get; set; }
        public string FavoriteGames { get; set; }
        public string FavoriteFilms { get; set; }
        public string Activities { get; set; }

        public User()
        {
            Followings = new List<Follow>();
            Followers = new List<Follow>();
            ImageName = "default.png";
            ImagePath = "/Photos/default.png ";
        }

    }
}
