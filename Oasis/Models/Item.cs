using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oasis.Models
{
	public class Item
	{
		[Key]
		public int ItemId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public double AverageRating { get; set; }
		public string ItemImage { get; set; }
		public string ItemVideo { get; set; }
		public string Category { get; set; }
		public int Quantity { get; set; }
		public DateTime? DateSold { get; set; }
		public DateTime? DateOnMarket { get; set; }

		public string SellerEmail { get; set; }
		[ForeignKey("Email")]
		public User Seller { get; set; }
	}
}