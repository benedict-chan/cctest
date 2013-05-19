using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BenedictWebApi.Models;

namespace BenedictWebApi.Controllers
{
    public class AdvertisementBookingController : ApiController
    {
        private readonly IBookingRepository _repo;

        public AdvertisementBookingController(IBookingRepository repo)
        {
            this._repo = repo;
        }

        public IEnumerable<Booking> Get()
        {
            return this._repo.GetAll();
        }

        public Booking Get(int id)
        {
            return this._repo.Get(id);
        }

        //public HttpResponseMessage Post(Booking item)
        //{
        //    var newBooking = this._repo.Add(item);
        //    var response = Request.CreateResponse<Booking>(HttpStatusCode.Created, newBooking);
        //    string uri = Url.Route(null, new { id = newBooking.Id });
        //    response.Headers.Location = new Uri(Request.RequestUri, uri);
        //    return response;
        //}
        public Booking Post(Booking item)
        {
            var newBooking = this._repo.Add(item);
            return newBooking;
        }

        public HttpResponseMessage Delete(int id)
        {
            this._repo.Remove(id);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
