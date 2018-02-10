using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWorm.Models {

	public class Books {

		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Author { get; set; }

		[Required]
		public string CoverArt { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public int Rating { get; set; }

		public string BookSeries { get; set; }

		public readonly int[] RatingList = new int[] {
			1,
			2,
			3,
			4,
			5
		};
	}
}