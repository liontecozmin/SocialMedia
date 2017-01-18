using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Web.DataBase.Profile
{
    public class UserProfileRepository : IUserProfileRepository
    {
        UserProfileContext context = new UserProfileContext();
        public void Add(UserProfile a)
        {
            context.UsersProfile.Add(a);
            context.SaveChanges();
        }

        public UserProfile FindByEmail(string mail)
        {
            foreach (var user in context.UsersProfile)
            {
                if (mail == user.Email)
                    return user;
            }

            return new UserProfile("", "", "");
        }
    }
}
