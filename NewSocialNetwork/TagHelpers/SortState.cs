using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSocialNetwork.TagHelpers
{
    public enum SortState
    {
        NameAsc,    // по возрастанию
        NameDesc,   // по убыванию
        SurnameAsc,
        SurnameDesc,
        CountryAsc,
        CountryDesc,
        BirthdayAsc,
        BirthdayDesc
    }
}
