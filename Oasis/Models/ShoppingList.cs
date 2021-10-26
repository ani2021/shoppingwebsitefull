using System.ComponentModel.DataAnnotations;
namespace Oasis.Models
{
	public class ShoppingList
	{
		[Key]
		public int ListId { get; set; }
		public string ListName { get; set; }
		public string ItemName { get; set; }

		public int ItemId { get; set; }
		public string UserEmail { get; set; }
	}
}