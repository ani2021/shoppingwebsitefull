using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oasis.Models
{
	public class Graph
	{
		[Key]
		public int Id { get; set; }
		public string Data { get; set; }
		public string GraphType { get; set; }

		public string SellerEmail { get; set; }
		[ForeignKey("Email")]
		public User Seller { get; set; }
	}
}