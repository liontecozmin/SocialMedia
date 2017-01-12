using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SC.Core;

namespace SC.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void when_get_users()
        {
            User user = new User(Guid.NewGuid(),"Sandu", "Gheorghe", "sandu@yahoo.com", "074567898", true,"B6" ,"B6");
            Assert.IsTrue(user.firstName != null);
            Assert.IsTrue(user.lastName != null);
            Assert.IsNotNull(user.email);
            Assert.IsNotNull(user.phoneNumber);
            Assert.IsNotNull(user.isAdministrator);
            Assert.IsNotNull(user.groups);
            Assert.IsNotNull(user.adm_groups);
        }

        public static void Main(string[] args)
        {

        }
    }
}
