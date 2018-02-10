using System.Data.Entity;

namespace BookWorm.Models {

	public class BookEntity : DbContext	{

		public BookEntity() : base() {}

		public DbSet<Books> Books { get; set; }
	}
}