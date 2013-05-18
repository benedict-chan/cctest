using System;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BenedictWebApi.Controllers;
using BenedictWebApi.Models;
using Moq;

namespace BenedictWebApi.Tests.Controllers
{
    [TestClass]
    public class AdvertisementBookingTest
    {
        [TestMethod]
        public void PostBooking()
        {
            //Setting up the mock
            var mock = new Mock<IBookingRepository>();
            mock.Setup(b => b.Add(It.IsAny<Booking>())).Returns(new Booking() { Id = 8, ClientName = "Benedict Mock", Duration = 30, ExpectedDate = DateTime.Now });
            var repo = mock.Object;


            //Try to mock Request here for web api
            //However it would need to mock an extension method, lets make it simple here for the request to just return the Object and not using the Request object

            //var request = new Mock<HttpRequestMessage>(MockBehavior.Strict);
            //request.Setup(r => r.CreateResponse<Booking>(System.Net.HttpStatusCode.Created, It.IsAny<Booking>())).Returns(new HttpResponseMessage());
            //request.Setup(r => r.RequestUri).Returns(new Uri("~"));
            //var context = new Mock<System.Web.Http.Controllers.HttpControllerContext>();
            //context.SetupGet(x => x.Request).Returns(request.Object);
            

            AdvertisementBookingController controller = new AdvertisementBookingController(repo);
            //controller.ControllerContext = context.Object;
            // Act
            var response = controller.Post(new Booking() { Id = 7, ClientName = "Benedict Test", Duration = 30, ExpectedDate = DateTime.Now });
            //Console.WriteLine(response.Content);
            

            // Assert
            Assert.AreEqual(8, response.Id);
        }
    }
}
