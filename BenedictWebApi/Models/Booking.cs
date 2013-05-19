using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace BenedictWebApi.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Display(Name = "Your Name", Prompt = "Booking Name")]
        [Required(ErrorMessage = "Please enter your name")]
        public string ClientName { get; set; }

        public DateTime ExpectedDate { get; set; }
        public int Duration { get; set; }
    }
}