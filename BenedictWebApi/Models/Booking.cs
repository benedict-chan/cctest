using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenedictWebApi.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime ExpectedDate { get; set; }
        public int Duration { get; set; }
        public string ClientName { get; set; }
    }
}