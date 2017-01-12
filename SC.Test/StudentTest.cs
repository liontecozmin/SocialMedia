using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SC.Core;

namespace SC.Test
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void when_get_students()
        {
            Student student = new Student(Guid.NewGuid(),"Sandu", "Gheorghe", "sandu@yahoo.com", "074567898", true, "B6", "B6","B6",3);
            Assert.IsTrue(student.firstName != null);
            Assert.IsTrue(student.lastName != null);
            Assert.IsNotNull(student.email);
            Assert.IsNotNull(student.phoneNumber);
            Assert.IsNotNull(student.isAdministrator);
            Assert.IsNotNull(student.groups);
            Assert.IsNotNull(student.adm_groups);
            Assert.IsNotNull(student.grupa);
            Assert.IsNotNull(student.an);
        }
    }
}
