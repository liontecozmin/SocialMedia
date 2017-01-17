using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SC.Web;
using SC.Web.DataBase.Profile;

namespace SC.Test
{
    [TestClass]
    public class PostTest
    {

        [TestMethod]
        public void when_get_post()
        {
            Post post = new Post("alex@info.uaic.ro", "B6", DateTime.Now,"post1");
            Assert.IsTrue(post.email == "alex@info.uaic.ro");
            Assert.IsTrue(post.group =="B6");
            Assert.IsTrue(post.postDate != null);
            Assert.IsTrue(post.message == "post1");

        }

       
    }
}
