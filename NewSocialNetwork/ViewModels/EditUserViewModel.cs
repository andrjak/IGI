﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewSocialNetwork.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
