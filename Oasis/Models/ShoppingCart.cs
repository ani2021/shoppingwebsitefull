using System.ComponentModel.DataAnnotations;
namespace Oasis.Models
{
	public class ShoppingCart
	{
		[Key]
		public int CartId { get; set; }
		public string UserEmail { get; set; }
		public string ItemName { get; set; }
		public int Quantity { get; set; }
		public double Price { get; set; }
		public string ItemDescription { get; set; }
		public string Image { get; set; }
	}
}