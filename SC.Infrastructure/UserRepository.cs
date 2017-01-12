using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SC.Core;

namespace SC.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        UserContext context = new UserContext();
        public void Add(User a)
        {
            context.User.Add(a);
            context.SaveChanges();
        }

        public void Remove(int UserID)
        {
           // User a = context.User.FindById(UserID);
           // context.User.Remove(a);
           // context.SaveChanges();
        } 

        public IEnumerable<User> GetUsers()
        {
            return context.User;
        }

      public User FindById(Guid UserID)
        {
            // var user = (from r in context.User where r.id == UserID select r).FirstOrDefault();
            var user = new User(Guid.NewGuid(),"Marius","Ales","abc@yahoo.com","048324",true,"B6","B6");
           return user;
        }

    }
}
