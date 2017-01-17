using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SC.Web;
using SC.Web.DataBase.Profile;

namespace SC.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void when_get_users()
        {
            UserProfile user = new UserProfile("alex@info.uaic.ro","Alex","Popescu");
            Assert.IsTrue(user.email != null);
            Assert.IsTrue(user.firstName != null);
            Assert.IsTrue(user.lastName != null);

        }



        public static void Main(string[] args)
        {

        }
    }
}
