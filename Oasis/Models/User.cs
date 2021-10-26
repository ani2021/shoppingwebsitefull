using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oasis.Models
{
	public class User : IdentityUser
	{
		public User()
		{
			ShoppingCart = new HashSet<Item>();
		}
		public string Role { get; set; }
		public int ItemsPerPage { get; set; }
		public string FavoriteCategories { get; set; }
		public bool HasMembership { get; set; }
		public string Salt { get; set; }
		public ICollection<Item> ShoppingCart;

		public static explicit operator User(Task<User> v)
		{
			throw new NotImplementedException();
		}
	}
}