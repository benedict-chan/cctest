using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BenedictWebApi.Models;

namespace BenedictWebApi.Tests.Repositories
{
    [TestClass]
    public class BookingRepositoryTest
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestCleanup]
        public void Clean()
        {
        }

        [TestMethod]
        public void AddBooking()
        {
            var repo = new BookingRepository();
            var booking = repo.Add(new Booking() { ExpectedDate = DateTime.Now, ClientName = "Test", Duration = 30 });
            Assert.IsNotNull(booking);

        }
    }
}
