﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using VidlyApp.DbContext;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {

            var genres = _context.Genres.ToList();

            var movieModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", movieModel);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movies = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movies == null)
            {
                return HttpNotFound();
            }

            var moviewModel = new MovieFormViewModel(movies)
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", moviewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;

                // add stock to numberAvailable
                var currentStock = movie.Stock;
                movie.NumberAvailable = (byte)currentStock;

                _context.Movies.Add(movie);
            }
            else
            {
                var movieDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieDb.Name = movie.Name;
                movieDb.ReleaseDate = movie.ReleaseDate;
                movieDb.GenreId = movie.GenreId;
                movieDb.Stock = movie.Stock;
            }


            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        // GET: Movies
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");

            return View("ReadOnlyList");
        }



    }
}
