using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewSocialNetwork.Models
{
    public class Chat
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<UserChat> Users { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
