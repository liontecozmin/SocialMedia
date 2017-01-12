using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Core
{
    public class User
    {
        // [Required]
        public Guid id { get; set; }

       // [Required]
       // [MaxLength(50)]
        public string firstName { get; set; }

        public string lastName { get; set; }

       // [Required]
        public string email { get; set; }

        public string phoneNumber { get; set; }

        public bool isAdministrator { get; set; }

        public string groups { get; set; }  // grupuri din care face parte

        public string adm_groups { get; set; }  //grupuri asupra carora are drepturi de add,remove user.

        public User(Guid id,string fname, string lname,string email,string phoneNumber,bool isAdministrator,string groups,string adm_groups)
        {
            this.id = id;
            firstName = fname;
            lastName = lname;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.isAdministrator = isAdministrator;
            this.groups = groups;
            this.adm_groups = adm_groups;
            
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Sunt in User.cs");
            Console.ReadKey();
        }
    }
}
