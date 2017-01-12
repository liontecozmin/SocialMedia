using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Core
{
    public class Teacher : User
    {
        public Teacher(Guid id,string fname, string lname, string email, string phoneNumber, bool isAdministrator, string groups, string adm_groups) : base(id,fname, lname, email, phoneNumber, isAdministrator,groups,adm_groups)
        {
        }
    }
}
