using HelloWeb.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWeb.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Test]
        public void TestIndexCase01()
        {
            var loggerMock = new Mock<ILogger<HomeController>>();
            
            var controller = new HomeController(loggerMock.Object);
            var view = controller.Index();
            Assert.IsInstanceOf<ViewResult>(view);
        }
    }
}
