using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SC.Web
{ 
    public class Group
    {
    [Key]
    public int id { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string group_name { get; set; }
    

    public Group(string _email, string _group)
    {
        email = _email;
        group_name = _group;
        

    }

    public Group()
    {
        id = 1000;
        email = "";
        group_name = "";

    }
}
}
