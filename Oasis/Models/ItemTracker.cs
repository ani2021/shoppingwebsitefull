using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oasis.Models
{
	public class ItemTracker
	{
		[Key]
		public int Id { get; set; }
		public int TotalViewed { get; set; }
		public int TotalPurchased { get; set; }
		public string ItemName { get; set; }
	}
}