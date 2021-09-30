using HelloWeb.Web.Controllers;
using HelloWeb.Web.Models;
using HelloWeb.Web.Repositories;
using HelloWeb.Web.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HelloWeb.Tests.Controllers
{
    
    public class AuthControllerTest
    {
        [Test]
        public void TestLoginPostFail()
        {

            var mock = new Mock<IUserRepository>();
            mock.Setup(o => o.FindUserByCredentials("admin", "1234")).Returns((User)null);
            var controller = new AuthController(mock.Object, null);

            var result = controller.Login("admin", "1234") as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsFalse(controller.ModelState.IsValid);
        }

        //[Test]
        //public void TestLoginPostSuccess()
        //{
        //    var request = new Mock<HttpRequest>();
        //    request.Setup(x => x.Scheme).Returns("http");
        //    request.Setup(x => x.Host).Returns(HostString.FromUriComponent("http://localhost:8080"));
        //    request.Setup(x => x.PathBase).Returns(PathString.FromUriComponent("/"));

        //    var authServiceMock = new Mock<IAuthenticationService>();
        //    authServiceMock
        //        .Setup(_ => _.SignInAsync(It.IsAny<HttpContext>(), It.IsAny<string>(), It.IsAny<ClaimsPrincipal>(), It.IsAny<AuthenticationProperties>()))
        //        .Returns(Task.FromResult((object)null));

        //    var serviceProviderMock = new Mock<IServiceProvider>();
        //    serviceProviderMock
        //        .Setup(_ => _.GetService(typeof(IAuthenticationService)))
        //        .Returns(authServiceMock.Object);

            

        //    var controllerContext = new ControllerContext()
        //    {
        //        HttpContext = new DefaultHttpContext
        //        {
        //            RequestServices = serviceProviderMock.Object,
        //        },

        //    };

        //    var mock = new Mock<IUserRepository>();
        //    mock.Setup(o => o.FindUserByCredentials("admin", "admin")).Returns(new User());

        //    var controller = new AuthController(mock.Object)
        //    {
        //        ControllerContext = controllerContext
        //    };
            
        //    var result = controller.Login("admin", "admin");

        //    Assert.IsInstanceOf<RedirectToActionResult>(result);
        //}

        [Test]
        public void TestLoginPostSuccess()
        {           

            var mock = new Mock<IUserRepository>();
            mock.Setup(o => o.FindUserByCredentials("admin", "admin")).Returns(new User());

            var authMock = new Mock<IAuthService>();            

            var controller = new AuthController(mock.Object, authMock.Object);

            var result = controller.Login("admin", "admin");

            Assert.IsInstanceOf<RedirectToActionResult>(result);
        }
    }
}
