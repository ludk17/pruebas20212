using HelloWeb.Tests.Repositories.Mocks;
using HelloWeb.Web.Db;
using HelloWeb.Web.Models;
using HelloWeb.Web.Repositories;
using HelloWeb.Web.ViewModels.QueryModels;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWeb.Tests.Repositories
{
    public class UserRepositoryTest
    {
        private Mock<CalidadAppContext> mockContext;
        
        [SetUp]
        public void SetUp()
        {
            mockContext = AplicationContextMock.GetApplicationContextMock();
        }

        [Test]
        public void TestGetAllCaso01()
        {
            var respository = new UserRepository(mockContext.Object);
            var users = respository.GetAll();

            Assert.AreEqual(6, users.Count);
        }

        [Test]
        public void TestGetAllCaso02()
        {
            var respository = new UserRepository(mockContext.Object);
            var users = respository.GetAll(false);

            Assert.AreEqual(4, users.Count);
        }

        [Test]
        public void TestGetAllCaso03()
        {
            var respository = new UserRepository(mockContext.Object);
            var users = respository.GetAll(true);

            Assert.AreEqual(2, users.Count);
        }

        [Test]
        public void TestFindUserByCredentialsCaso01()
        {
            var respository = new UserRepository(mockContext.Object);
            var user = respository.FindUserByCredentials("admin", "admin");

            Assert.AreEqual(1, user.Id);
        }

        [Test]
        public void TestFindUserByCredentialsCaso02()
        {
            var respository = new UserRepository(mockContext.Object);
            var user = respository.FindUserByCredentials("admin2", "admin2");

            Assert.IsNull(user);
        }

        [Test]
        public void TestGetAllUserByUsernameCaso01()
        {
            var respository = new UserRepository(mockContext.Object);
            var user = respository.GetAllUserByQuery("user");

            Assert.AreEqual(4, user.Count);
        }

        [Test]
        public void TestGetAllUserByUsernameCaso02()
        {
            var respository = new UserRepository(mockContext.Object);
            var user = respository.GetAllUserByQuery("admin");

            Assert.AreEqual(2, user.Count);
        }

        [Test]
        public void TestGetAllUserByUsernameCaso03()
        {
            var respository = new UserRepository(mockContext.Object);
            var user = respository.GetAllUserByQuery("pepito");

            Assert.AreEqual(0, user.Count);
        }

        [Test]
        public void TestGetAllUserByQueryCase01()
        {
            var respository = new UserRepository(mockContext.Object);
            var query = new UserQuery { Username = "user" };
            var users = respository.GetAllUserByQuery(query);

            Assert.AreEqual(4, users.Count);
        }

        [Test]
        public void TestGetAllUserByQueryCase02()
        {
            var respository = new UserRepository(mockContext.Object);
            var query = new UserQuery { Username = "user", CreatedAt = new DateTime(2021, 08, 23) };
            var users = respository.GetAllUserByQuery(query);

            Assert.AreEqual(2, users.Count);
        }

        [Test]
        public void TestGetAllUserByQueryCase03()
        {
            var respository = new UserRepository(mockContext.Object);
            var query = new UserQuery {  };
            var users = respository.GetAllUserByQuery(query);

            Assert.AreEqual(6, users.Count);
        }

        [Test]
        public void TestGetAllUserByQueryCase04()
        {
            var respository = new UserRepository(mockContext.Object);
            var query = new UserQuery { IsDeleted = true };
            var users = respository.GetAllUserByQuery(query);

            Assert.AreEqual(2, users.Count);
        }

        [Test]
        public void TestGetAllUserByQueryCase05()
        {
            var respository = new UserRepository(mockContext.Object);
            var query = new UserQuery { IsDeleted = true, Username = "admin" };
            var users = respository.GetAllUserByQuery(query);

            Assert.AreEqual(1, users.Count);
        }
    }
}
