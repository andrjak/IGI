﻿using System;
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
        public DateTime Birthday { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
    }
}
