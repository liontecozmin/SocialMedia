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
        
        
                public Email FindEmail(string from,string to, string subject1,string message1)
        {
            foreach (var email in context.Emails)
            {
                if (from==email.from && to==email.to && subject1 == email.subject && message1 == email.message)
                    return email;
            }

            return new Email("", "", "", "", DateTime.Now);
        }



    }
}
