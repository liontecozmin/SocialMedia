using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SC.Core
{
    public interface IUserRepository
    {
        void Add(User b);
        void Remove(int UserID);
        IEnumerable<User> GetUsers();
        User FindById(Guid UserID);
    }
}
