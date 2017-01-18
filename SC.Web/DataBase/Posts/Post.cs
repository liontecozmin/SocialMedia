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
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Group { get; set; }
        [Required]
        public DateTime PostDate {get; set;}
        [Required]
        public string Message { get; set; }

        public Post(string mail,string grp,DateTime date,string mess)
        {
            Email = mail;
            Group = grp;
            PostDate = date;
            Message = mess;
        }

        public Post()
        {
            Id = 1;
            Email = "";
            Group = "";
            PostDate = DateTime.Now;
            Message = "";
        }


    }
}
