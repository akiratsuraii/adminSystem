using Microsoft.AspNetCore.Identity;
using System;

namespace adminSystem.Models.Identity
{
    public class UserInfo:IdentityUser
    {

        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string IconPath { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Enable { get; set; }

    }
}
