using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenedictWebApi.Models
{
    /// <summary>
    /// a Simple Booking Repository 
    /// </summary>
    public class BookingRepository : IBookingRepository
    {
        private BookingDb db = new BookingDb();

        public IEnumerable<Booking> GetAll()
        {
            return db.Bookings;
        }

        public Booking Get(int id)
        {
            return db.Bookings.FirstOrDefault(s => s.Id == id);
        }

        public Booking Add(Booking newBooking)
        {
            db.Bookings.Add(newBooking);
            db.SaveChanges();
            return newBooking;
        }

        public void Remove(int id)
        {
            var booking = db.Bookings.Find(id);
            db.Bookings.Remove(booking);
            db.SaveChanges();
        }
    }
}