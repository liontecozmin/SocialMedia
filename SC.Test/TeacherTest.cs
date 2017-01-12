using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SC.Core;
namespace SC.Test
{
    [TestClass]
    public class TeacherTest
    {
        [TestMethod]
        public void when_get_teachers()
        {
            Teacher teacher = new Teacher(Guid.NewGuid(),"Sandu", "Gheorghe", "sandu@yahoo.com", "074567898", true, "B6", "B6");
            Assert.IsTrue(teacher.firstName != null);
            Assert.IsTrue(teacher.lastName != null);
            Assert.IsNotNull(teacher.email);
            Assert.IsNotNull(teacher.phoneNumber);
            Assert.IsNotNull(teacher.isAdministrator);
            Assert.IsNotNull(teacher.groups);
            Assert.IsNotNull(teacher.adm_groups);
        }
    }
}
