using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using BookWorm.Models;

namespace BookWorm.Controllers {

    public class SearchController : Controller {

		public ActionResult Index() {
			return View(new SearchBooks());
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Index(SearchBooks searchBook) {
			using (BookEntity BE = new BookEntity()) {
				SearchBooks newSearch = new SearchBooks();

				newSearch.BookList.AddRange(BE.Books.Where(b => 
					b.Title.Contains(searchBook.Title) &&
					b.Author.Contains(searchBook.Author) &&
					b.Rating.Equals(searchBook.Rating) &&
					b.BookSeries.Equals(searchBook.BookSeries)
				));

				foreach(var book in newSearch.BookList) {
					Console.WriteLine(book);
				}

				return View(newSearch);
			}
		}
	}
}