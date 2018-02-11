using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using BookWorm.Models;

namespace BookWorm.Controllers {

    public class SearchController : Controller {

		public ActionResult Index()	{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Index(SearchBooks searchBook) {
			if (!ModelState.IsValid) {
				return View();
			}

			using (BookEntity BE = new BookEntity()) {
				var bookList = BE.Books.AddRange(BE.Books.Where(b => 
					b.Title.Contains(searchBook.Title) &&
					b.Author.Contains(searchBook.Author) &&
					b.Rating.Equals(searchBook.Rating) &&
					b.BookSeries.Equals(searchBook.BookSeries)
				));

				if (bookList == null) {
					ModelState.AddModelError("", "That book doesn't exist.");
					return View("Index", searchBook);
				}

				return RedirectToAction("UserPolicies", "Admin");
			}
		}
	}
}