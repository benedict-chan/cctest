using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BenedictWebApi.Models
{
    /// <summary>
    /// CodeFirst Initializer for the BookingDb
    /// </summary>
    public class BookingInitializer : DropCreateDatabaseIfModelChanges<BookingDb>//DropCreateDatabaseAlways<BookingDb> //
    {
        protected override void Seed(BookingDb context)
        {
            base.Seed(context);

            //context.Bookings.Add(new Booking() { ExpectedDate = DateTime.Now, Duration = 30, ClientName = "Benedict" });

        }
    }
}