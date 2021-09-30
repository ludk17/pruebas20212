using HelloWeb.Web.Db;
using HelloWeb.Web.Models;
using HelloWeb.Web.Repositories;
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
        [Test]
        public void TestGetAllCaso01()
        {
            var data = new List<User>
            {
                new User { Id = 1, Username = "admin", Password = "admin" },
                new User { Id = 2, Username = "admin", Password = "admin" },
                new User { Id = 3, Username = "admin", Password = "admin" },
                new User { Id = 4, Username = "admin", Password = "admin" },
                new User { Id = 5, Username = "admin", Password = "admin" }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<User>>();
            mockSet.As<IQueryable<User>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<User>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<User>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<User>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CalidadAppContext>(new DbContextOptions<CalidadAppContext>());
            mockContext.Setup(c => c.Users).Returns(mockSet.Object);


            var respository = new UserRepository(mockContext.Object);
            var users = respository.GetAll();

            Assert.AreEqual(5, users.Count);
        }

        [Test]
        public void TestFindUserByCredentialsCaso01()
        {
            var data = new List<User>
            {
                new User { Id = 1, Username = "admin", Password = "admin" },
                new User { Id = 2, Username = "user1", Password = "user1" },
                new User { Id = 3, Username = "user2", Password = "user2" },
                new User { Id = 4, Username = "user3", Password = "user3" },
                new User { Id = 5, Username = "user4", Password = "user4" }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<User>>();
            mockSet.As<IQueryable<User>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<User>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<User>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<User>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CalidadAppContext>(new DbContextOptions<CalidadAppContext>());
            mockContext.Setup(c => c.Users).Returns(mockSet.Object);


            var respository = new UserRepository(mockContext.Object);
            var user = respository.FindUserByCredentials("admin", "admin2");

            Assert.AreEqual(1, user.Id);
        }
    }
}
