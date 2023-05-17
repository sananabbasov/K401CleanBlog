using System;
namespace Web.Models
{
	public class Article
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public bool IsDeleted { get; set; }
		public bool IsActive { get; set; }
		public string PhotoUrl { get; set; }
		public string SeoUrl { get; set; }
		public int AuthorId { get; set; }
		public Author Author { get; set; }
		// AuthorId foreign key references Author(Id)

	}
}

