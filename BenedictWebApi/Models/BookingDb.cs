using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace BenedictWebApi.Models
{
    public class BookingDb : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }

        //public static BookingDb()
        //{
        //    Database.SetInitializer
        //}
    }
}