using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using BenedictWebApi.Models;

namespace BenedictWebApi.Tests.Repositories
{
    [TestClass]
    public class BookingRepositoryTest
    {
        private BookingRepository _repo = new BookingRepository();

        [TestInitialize]
        public void Init()
        {

        }

        [TestCleanup]
        public void Clean()
        {
        }

        [TestMethod]
        public void GetBooking()
        {
            var booking = this._repo.Get(1);
            Assert.IsNotNull(booking);
            Assert.AreEqual(1, booking.Id);
        }

        [TestMethod]
        public void AddBooking()
        {
            var booking = this._repo.Add(new Booking() { ExpectedDate = DateTime.Now, ClientName = "Test", Duration = 30 });
            Assert.IsNotNull(booking);

        }
    }
}
