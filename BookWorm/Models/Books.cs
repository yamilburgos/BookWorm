using System;
using System.ComponentModel.DataAnnotations;

namespace BookWorm.Models {

	public class Books {

		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Title { get; set; }

		[Required]
		[MaxLength(100)]
		public string Author { get; set; }

		[Required]
		[MaxLength(255)]
		[Display(Name = "Cover Art")]
		public string CoverArt { get; set; }

		[Required]
		[MaxLength(255)]
		public string Description { get; set; }

		[Required]
		[Range(1, 5)]
		public int Rating { get; set; }

		[MaxLength(100)]
		[Display(Name = "Book Series")]
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