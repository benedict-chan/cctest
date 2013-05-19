using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace BenedictWebApi.Models
{
    /// <summary>
    /// CodeFirst DbContext
    /// </summary>
    public class BookingDb : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }


    }
}