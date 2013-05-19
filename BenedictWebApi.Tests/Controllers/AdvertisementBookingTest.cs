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

            //Inject the mocked repository into controller
            AdvertisementBookingController controller = new AdvertisementBookingController(repo);
            var response = controller.Post(new Booking() { Id = 7, ClientName = "Benedict Test", Duration = 30, ExpectedDate = DateTime.Now });

            // Assert
            Assert.AreEqual(8, response.Id);
        }
    }
}
