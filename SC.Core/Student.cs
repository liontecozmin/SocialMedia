using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Core
{
    public class Student : User
    {
        public string grupa { get; set; }

        public int an { get; set; }

        public Student(Guid id,string fname, string lname, string email, string phoneNumber, bool isAdministrator, string groups, string adm_groups,string grupa,int an) : base(id,fname, lname, email, phoneNumber, isAdministrator,groups,adm_groups)
        {
            this.grupa = grupa;
            this.an = an;
        }
    }
}
