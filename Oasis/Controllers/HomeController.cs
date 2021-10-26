using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Oasis.Models;
using Oasis.Services;
using Oasis.Statics;
using AppContext = Oasis.AppStart.AppContext;

namespace Oasis.Controllers
{
	public class HomeController : Controller
	{
		private AppContext _context;
		private readonly UserManager<User> um;
		public HomeController(UserManager<User> um)
		{
			this.um = um;
			this._context = new AppContext();
			/*this.rm = rm;
			IdentityRole buyer = new IdentityRole { Name = Configurations.RoleTitle.Buyer };
			IdentityRole seller = new IdentityRole { Name = Configurations.RoleTitle.Seller };
			rm.CreateAsync(seller);
			rm.CreateAsync(buyer);
			/*Item item = new Item { ItemId = 1, Name = "Xbox One", Description = "Best Gaming System Ever", Price = 400.00, SellerEmail = "seller@email.com", AverageRating = 8.6 };
			Item item2 = new Item { ItemId = 2, Name = "PlayStation 5", Description = "Best Gaming System Ever", Price = 400.00, SellerEmail = "seller@email.com", AverageRating = 9.6 };
			context.Items.Add(item);
			context.Items.Add(item2);
			context.SaveChanges();*/
		}

		public async System.Threading.Tasks.Task<IActionResult> IndexAsync()
		{
			try
			{
				ItemComparer itemComparer = new ItemComparer();
				User u = await um.GetUserAsync(HttpContext.User);
				ShoppingListComparer shoppingListComparer = new ShoppingListComparer();
				ViewBag.ForSale = _context.Items.AsParallel().OrderBy(itm => itm.Category).Distinct(itemComparer).Take(5);
				if(u != null)
				{
					ViewBag.ListItems = _context.ShoppingLists.AsParallel().Where(li => li.UserEmail.Equals(u.Email)).Distinct(shoppingListComparer);
				}
			}
			catch(Exception e)
			{
				e.ToString();
			}
			return View();
		}
	}
}