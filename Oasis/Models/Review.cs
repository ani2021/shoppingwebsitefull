using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oasis.Models
{
	public class Review
	{
		[Key]
		public int ReviewId { get; set; }
		public string ReviewMessage { get; set; }
		public string ReviewerEmail { get; set; }
		public string ReviewItem { get; set; }
	}
}