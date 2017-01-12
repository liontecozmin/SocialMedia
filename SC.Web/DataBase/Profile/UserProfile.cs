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
        public int id { get; set; }

        public string email { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public UserProfile(string mail, string fname, string lname)
        {
            email = mail;
            firstName = fname;
            lastName = lname;
        }

        public UserProfile()
        {
            id = 1000;
            email = "";
            firstName = "";
            lastName = "";
        }
    }
}
