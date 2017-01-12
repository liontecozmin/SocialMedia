using SC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SC.Web;

namespace SC.Web
{
    public class EmailRepository : IEmailRepository
    {
        EmailContext context = new EmailContext();
        public void Add(Email a)
        {
            context.Emails.Add(a);
            context.SaveChanges();
        }



    }
}
