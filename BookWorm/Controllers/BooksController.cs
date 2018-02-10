using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using BookWorm.Models;

namespace BookWorm.Controllers {

    public class BooksController : Controller {
		public ActionResult Index() {
            return View();
        }

		public ActionResult AddBooks() {
			Books bookModel = new Books();

			return View("BookForm", bookModel);
		}


		[HttpPost]
		public ActionResult SaveBooks(Books books) {
			//// Changes the flow of the program by using validation
			//// data. Still return the same view if it isn't valid.
			//if (!ModelState.IsValid)
			//{
			//	MovieFormViewModel viewModel = new MovieFormViewModel
			//	{
			//		// Takes the result given from the above query to use for the view.
			//		Movie = movie,
			//		// A query to contain all genres available via a list.
			//		Genres = _context.Genres.ToList()
			//	};

			//	// Still return MovieForm's View page to visit. Also passes viewModel data.
			//	return View("MovieForm", viewModel);
			//}

			//if (movie.Id == 0)
			//{
			//	// Done for new movies who yet to have an id.
			//	// Added to the dbContext memory, not the database!
			//	movie.DateAdded = DateTime.Now;
			//	_context.Movies.Add(movie);
			//}

			//else
			//{
			//	// First query the database to find the movie with this existing id.
			//	Movie movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
			//	// Then pass along the movie's new information to this chosen variant.
			//	movieInDb.Name = movie.Name;
			//	movieInDb.GenreId = movie.GenreId;
			//	movieInDb.NumberInStock = movie.NumberInStock;
			//	movieInDb.ReleaseDate = movie.ReleaseDate;
			//}

			//// This will save the changes to the database.
			//_context.SaveChanges();
			//// Redirects the user back to the list of movies (to Index).
			//return RedirectToAction("Index", "Movies");
			return View();
		}
	}
}