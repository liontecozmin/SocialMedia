using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Web
{
    public class GroupRepository : IGroupRepository
    {
        GroupContext context = new GroupContext();
        public void Add(Group a)
        {
            context.Groups.Add(a);
            context.SaveChanges();
        }

        public Group FindByGroupName(string email,string group_n)
        {
            foreach (var group in context.Groups)
            {
                if (group_n == group.Group_name && email == group.Email)
                    return group;
            }

            return new Group("", "");
        }

        public Group FindGroup(string group_n)
        {
            foreach (var group in context.Groups)
            {
                if (group_n == group.Group_name)
                    return group;
            }

            return new Group("", "");
        }






    }
}
