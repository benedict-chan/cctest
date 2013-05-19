using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace BenedictWebApi.Models
{
    /// <summary>
    /// Model for the Booking
    /// </summary>
    public class Booking
    {
        public int Id { get; set; }

        [Display(Name = "Booking Name", Prompt = "Booking Name")]
        //This is mainly for the Client side validation
        [Required(ErrorMessage = "Please enter your name")]
        public string ClientName { get; set; }

        public DateTime ExpectedDate { get; set; }
        public int Duration { get; set; }
    }
}