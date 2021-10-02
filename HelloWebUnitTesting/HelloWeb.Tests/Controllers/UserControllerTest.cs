using HelloWeb.Web.Controllers;
using HelloWeb.Web.Db;
using HelloWeb.Web.Models;
using HelloWeb.Web.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWeb.Tests.Controllers
{
    public class UserControllerTest
    {
        private Mock<IUserRepository> repository;

        [SetUp]
        public void SetUp()
        {
            repository = new Mock<IUserRepository>();
        }

        [Test]
        public void TestIndexIsOkCase01()
        {            
            
            repository.Setup(o => o.GetAll(It.IsAny<bool?>())).Returns(new List<User>());

            var controller = new UserController(repository.Object);
            var view = controller.Index() as ViewResult;

            Assert.IsInstanceOf<List<User>>(view.Model);
        }

        [Test]
        public void TestCreateWhenValidationFail()
        {
            
            var user = new User();
            var controller = new UserController(repository.Object);
            
            var view = controller.Create(user);

            Assert.IsInstanceOf<ViewResult>(view);
            repository.Verify(o => o.Create(user), Times.Exactly(0));
        }


        [Test]
        public void TestCreateWhenValidationSuccess()
        {
            var user = new User { Username = "admin", Password = "admin" };
            var controller = new UserController(repository.Object);
            var tempMock = new Mock<ITempDataDictionary>();
            controller.TempData = tempMock.Object;

            var view = controller.Create(user);

            Assert.IsInstanceOf<RedirectToActionResult>(view);
            repository.Verify(o => o.Create(user), Times.Once);
        }
    }
}
