using SC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SC.Web;

namespace SC.Web
{
    public class PostRepository : IPostRepository
    {
        PostContext context = new PostContext();
        public void Add(Post a)
        {
            context.Posts.Add(a);
            context.SaveChanges();
        }



    }
}
