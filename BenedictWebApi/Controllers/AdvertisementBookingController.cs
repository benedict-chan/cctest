using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BenedictWebApi.Models;

namespace BenedictWebApi.Controllers
{
    /// <summary>
    /// The Web Api Controller, as requested only have one method to expose, others are commented at the moment
    /// </summary>
    public class AdvertisementBookingController : ApiController
    {
        private readonly IBookingRepository _repo;

        public AdvertisementBookingController(IBookingRepository repo)
        {
            this._repo = repo;
        }

        //public IEnumerable<Booking> Get()
        //{
        //    return this._repo.GetAll();
        //}

        //public Booking Get(int id)
        //{
        //    return this._repo.Get(id);
        //}

        public Booking Post(Booking item)
        {
            var newBooking = this._repo.Add(item);
            return newBooking;
        }

        //public HttpResponseMessage Delete(int id)
        //{
        //    this._repo.Remove(id);
        //    return new HttpResponseMessage(HttpStatusCode.NoContent);
        //}
    }
}
