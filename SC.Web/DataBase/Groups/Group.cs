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
    public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Group_name { get; set; }
    

    public Group(string _email, string _group)
    {
        Email = _email;
        Group_name = _group;
        

    }

    public Group()
    {
        Id = 1000;
        Email = "";
        Group_name = "";

    }
}
}
