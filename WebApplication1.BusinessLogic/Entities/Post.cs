using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.BusinessLogic.Entities
{
	public class Post
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PostId { get; set; }

		[Required]
		[StringLength(50)]
		public string Title { get; set; }

		[Required]
		[StringLength(2500)]
		public string PostContent { get; set; }

		[Required]
		[StringLength(150)]
		public string ImageUrl { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime Date { get; set; }
	}
}