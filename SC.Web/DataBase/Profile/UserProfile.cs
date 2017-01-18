using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SC.Web.DataBase.Profile
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public UserProfile(string mail, string fname, string lname)
        {
            Email = mail;
            FirstName = fname;
            LastName = lname;
        }

        public UserProfile()
        {
            Id = 1000;
            Email = "";
            FirstName = "";
            LastName = "";
        }
    }
}
