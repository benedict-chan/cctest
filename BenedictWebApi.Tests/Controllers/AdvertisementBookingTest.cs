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
            var testBooking = new Booking() { Id = 8, ClientName = "Benedict Mock", Duration = 30, ExpectedDate = DateTime.Now };
            //Setting up the mock
            var mock = new Mock<IBookingRepository>();
            mock.Setup(b => b.Add(It.IsAny<Booking>())).Returns(testBooking);
            var repo = mock.Object;

            //Inject the mocked repository into controller
            AdvertisementBookingController controller = new AdvertisementBookingController(repo);
            var response = controller.Post(testBooking);

            // Assert
            Assert.AreEqual(testBooking.Id, response.Id);
        }

        [TestMethod]
        public void PostErrorBooking()
        {
            var testBooking = new Booking() { Id = 8, ClientName = "Benedict Mock", Duration = 30, ExpectedDate = DateTime.Now };
            //Setting up the mock
            var mock = new Mock<IBookingRepository>();
            mock.Setup(b => b.Add(It.IsAny<Booking>())).Returns((Booking)null);
            var repo = mock.Object;

            //Inject the mocked repository into controller
            AdvertisementBookingController controller = new AdvertisementBookingController(repo);
            var response = controller.Post(testBooking);

            // Assert
            Assert.IsNull(response);
        }
    }
}
