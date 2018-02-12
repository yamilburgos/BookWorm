using System.Data.Entity;
using System.Linq;
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
				SearchBooks bookResults = new SearchBooks();

				bookResults.BookList.AddRange(BE.Books.Where(b =>
					(b.Title.Trim().Contains(searchBook.Title.Trim() ?? " ")) &&
					(b.Author.Trim().Contains(searchBook.Author.Trim() ?? " ")) &&
					(b.BookSeries.Trim().Contains(searchBook.BookSeries.Trim())
						|| searchBook.BookSeries == null) &&
					(b.Rating == searchBook.Rating || searchBook.Rating == null)
				).Take(10));

				return View(bookResults);
			}
		}
	}
}