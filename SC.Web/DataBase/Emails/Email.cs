using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Web
{
    public class Email
    {
        [Key]
        public int id { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public DateTime emailDate { get; set; }

        public Email(string _from, string _to,string _subject,string _message, DateTime date)
        {
            from = _from;
            to = _to;
            subject = _subject;
            message = _message;
            emailDate = date;

        }

        public Email()
        {
            id = 1000;
            from = "";
            to = "";
            subject = "";
            message = "";
            emailDate = DateTime.Now;

        }
    }
}
