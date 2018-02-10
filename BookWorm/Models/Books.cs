using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWorm.Models {

	public class Books {

		public int Id { get; set; }

		public string Title { get; set; }

		public string Author { get; set; }

		public string CoverArt { get; set; }

		public string Description { get; set; }

		public int Rating { get; set; }

		public string BookSeries { get; set; }
	}
}