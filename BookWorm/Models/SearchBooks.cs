using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWorm.Models {

	[NotMapped]
	public class SearchBooks {
		public Books Books { get; set; }
		public List<Books> BookList { get; set; }

		[MaxLength(100)]
		public string Title { get; set; }

		[MaxLength(100)]
		public string Author { get; set; }

		[Range(1, 5)]
		public int? Rating { get; set; }

		[MaxLength(100)]
		[Display(Name = "Book Series")]
		public string BookSeries { get; set; }

		public SearchBooks() {
			Books = new Books();
			BookList = new List<Books>();
		}
	}
}