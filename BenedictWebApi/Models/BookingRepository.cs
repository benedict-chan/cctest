using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenedictWebApi.Models
{
    public class BookingRepository : IBookingRepository
    {
        private BookingDb db = new BookingDb();

        public Booking Get(int id)
        {
            return db.Bookings.FirstOrDefault(s => s.Id == id);
            //throw new NotImplementedException();
        }

        public Booking Add(Booking newBooking)
        {
            db.Bookings.Add(newBooking);
            db.SaveChanges();
            return newBooking;
            //throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            var booking = db.Bookings.Find(id);
            db.Bookings.Remove(booking);
            db.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}