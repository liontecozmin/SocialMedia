using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SC.Web;
using SC.Web.DataBase.Profile;

namespace SC.Test
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void when_get_group()
        {
            Group group = new Group("alex@info.uaic.ro", "B7");
            Assert.IsTrue(group.email == "alex@info.uaic.ro");
            Assert.IsTrue(group.group_name =="B7");


        }


    }
}
