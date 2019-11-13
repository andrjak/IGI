using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewSocialNetwork.ViewModels
{
    public class AdditionalSettingsViewModel
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Languages { get; set; }
        public string Interests { get; set; }
        public string FavoriteGames { get; set; }
        public string FavoriteFilms { get; set; }
        public string Activities { get; set; }
    }
}
