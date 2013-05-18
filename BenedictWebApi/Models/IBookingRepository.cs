using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenedictWebApi.Models
{
    public interface IBookingRepository
    {
        Booking Get(int id);
        Booking Add(Booking newBooking);
        void Remove(int id);
    }
}
