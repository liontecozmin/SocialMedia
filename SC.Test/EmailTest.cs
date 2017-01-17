using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SC.Web;
using SC.Web.DataBase.Profile;
namespace SC.Test
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void when_get_email()
        {
            Email email = new Email("alex@info.uaic.ro","batman@info.uaic.ro", "subject","Mesaj important", DateTime.Now);
            Assert.IsTrue(email.emailDate != null);
            Assert.IsTrue(email.from == "alex@info.uaic.ro");
            Assert.IsTrue(email.to =="batman@info.uaic.ro");
            Assert.IsTrue(email.subject == "subject");
            Assert.IsTrue(email.message == "Mesaj important");


        }


    }
}
