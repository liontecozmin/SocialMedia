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
        public int Id { get; set; }
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime EmailDate { get; set; }

        public Email(string _from, string _to,string _subject,string _message, DateTime date)
        {
            From = _from;
            To = _to;
            Subject = _subject;
            Message = _message;
            EmailDate = date;

        }

        public Email()
        {
            Id = 1000;
            From = "";
            To = "";
            Subject = "";
            Message = "";
            EmailDate = DateTime.Now;

        }
    }
}
