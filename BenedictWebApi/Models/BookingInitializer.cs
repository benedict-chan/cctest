using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BenedictWebApi.Models
{
    public class BookingInitializer : DropCreateDatabaseAlways<BookingDb> //DropCreateDatabaseIfModelChanges<BookingDb>
    {
        protected override void Seed(BookingDb context)
        {
            base.Seed(context);

            context.Bookings.Add(new Booking() { ExpectedDate = DateTime.Now, Duration = 30, ClientName = "Benedict" });

        }
    }
}