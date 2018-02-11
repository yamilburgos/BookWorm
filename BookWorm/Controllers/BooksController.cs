using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using BookWorm.Models;

namespace BookWorm.Controllers {

    public class BooksController : Controller {
		private BookEntity bookEntityContext = new BookEntity();

		public ActionResult Index() {
			using (BookEntity BE = new BookEntity()) {
				List<Books> bookList = new List<Books>();

				bookList.AddRange(BE.Books.Where(book => book.Id != 0));

				return View(bookList);
			}
		}

		public ActionResult NewBook() {
			return View("BookForm", new Books());
		}

		public ActionResult EditBook(int id) {
			using (BookEntity BE = new BookEntity()) {
				Books thisBook = BE.Books.SingleOrDefault(b => b.Id == id);
				if (thisBook == null) return HttpNotFound();

				else return View("BookForm", thisBook);
			}
		}

		[HttpPost]
		public ActionResult DeleteBook(int id) {
			using (BookEntity BE = new BookEntity()) {
				Books thisBook = BE.Books.SingleOrDefault(b => b.Id == id);
				if (thisBook == null) return HttpNotFound();

				bookEntityContext.Books.Attach(thisBook);
				bookEntityContext.Books.Remove(thisBook);
				bookEntityContext.SaveChanges();
				return RedirectToAction("Index");
			}
		}

		[HttpPost]
		public ActionResult SaveBooks(Books books) {
			if (!ModelState.IsValid) {
				Books bookList = new Books();

				return View("BookForm", bookList);
			}

			if (books.Id == 0) bookEntityContext.Books.Add(books);

			else {
				Books bookInDb = bookEntityContext.Books.Single(b => b.Id == books.Id);

				bookInDb.Title = books.Title;
				bookInDb.Author = books.Author;
				bookInDb.CoverArt = books.CoverArt;
				bookInDb.Description = books.Description;
				bookInDb.Rating = books.Rating;
				bookInDb.BookSeries = books.BookSeries;
			}

			bookEntityContext.SaveChanges();
			return RedirectToAction("Index", "Books");
		}
	}
}