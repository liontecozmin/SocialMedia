using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Web
{
    public class Post
    {

        [Key]
        public int id { get; set; }

        public string email { get; set; }

        public string group { get; set; }

        public DateTime postDate {get; set;}

        public string message { get; set; }

        public Post(string mail,string grp,DateTime date,string mess)
        {
            email = mail;
            group = grp;
            postDate = date;
            message = mess;
        }

        public Post()
        {
            id = 1;
            email = "";
            group = "";
            postDate = DateTime.Now;
            message = "";
        }


    }
}
