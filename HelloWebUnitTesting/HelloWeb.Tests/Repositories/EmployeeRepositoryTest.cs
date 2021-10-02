using HelloWeb.Tests.Repositories.Mocks;
using HelloWeb.Web.Db;
using HelloWeb.Web.Repositories;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWeb.Tests.Repositories
{
    public class EmployeeRepositoryTest
    {
        private Mock<CalidadAppContext> mockContext;

        [SetUp]
        public void SetUp()
        {
            mockContext = AplicationContextMock.GetApplicationContextMock();
        }

        [Test]
        public void TestFindByUsernameCase01()
        {
            var repository = new EmployeeRepository(mockContext.Object);
            var employee = repository.FindByUsername("admin");

            Assert.IsNotNull(employee);
            Assert.AreEqual(1, employee.Id);
        }

        [Test]
        public void TestFindByUsernameCase03()
        {
            var repository = new EmployeeRepository(mockContext.Object);
            var employee = repository.FindByUsername("user1");

            Assert.IsNull(employee);
        }
    }
}
