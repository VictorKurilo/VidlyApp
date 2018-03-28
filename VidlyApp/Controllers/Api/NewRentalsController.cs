using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyApp.DbContext;
using VidlyApp.Dtos;
using VidlyApp.Models;

namespace VidlyApp.Controllers.Api
{
    public class NewRentalsController : ApiController
    {

        private readonly ApplicationDbContext _dbContext;

        public NewRentalsController()
        {
            this._dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _dbContext.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var movies = _dbContext.Movies.Where(
                m=> newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available.");
                }

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _dbContext.Rentals.Add(rental);
            }

            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
