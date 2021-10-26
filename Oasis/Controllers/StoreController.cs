using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.WebPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Oasis.Models;
using Oasis.Services;
using Oasis.Statics;
using AppContext = Oasis.AppStart.AppContext;

namespace Oasis.Configurations
{
	public class StoreController : Controller
	{
		private AppContext _context;
		private ItemComparer itemComparer;
		private readonly UserManager<User> um;
		private ShoppingListComparer shoppingListComparer;
		public StoreController(UserManager<User> um)
		{
			this.um = um;
			_context = new AppContext();
			this.itemComparer = new ItemComparer();
			this.shoppingListComparer = new ShoppingListComparer();
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[Route("SubmitReview")]
		public async Task<IActionResult> SubmitReviewAsync(string review, string item)
		{
			if(review.IsEmpty())
			{
				return View(PageNavigation.ItemDetailsPage);
			}
			try
			{
				User u = await um.GetUserAsync(HttpContext.User);
				Review r = new Review { ReviewerEmail = u.Email, ReviewItem = item, ReviewMessage = review };
				_context.Reviews.Add(r);
				await _context.SaveChangesAsync();
				await RetrieveItemsAsync(item);
			}
			catch(Exception) { }
			return View(PageNavigation.ItemDetailsPage);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[Route("ItemDetails")]
		public async Task<IActionResult> ViewItemAsync(string item)
		{
			if(item.IsEmpty())
			{
				return View(PageNavigation.HomePage);
			}
			try
			{
				await RetrieveItemsAsync(item);
			}
			catch(Exception) { }
			return View(PageNavigation.ItemDetailsPage);
		}

		private async Task RetrieveItemsAsync(string item)
		{
			try
			{
				var itm = _context.Items.AsParallel().Where(i => i.Name.Equals(item));
				ViewBag.Item = itm.Distinct(itemComparer);
				ViewBag.Count = itm.Count();
				ViewBag.AvgRating = itm.Select(r => r.AverageRating).Average();
				User u = await um.GetUserAsync(HttpContext.User);
				if(u != null)
				{
					ViewBag.ShoppingLists = _context.ShoppingLists.AsParallel().Where(sl => sl.UserEmail.Equals(u.Email)).Distinct(shoppingListComparer);
				}
				ViewBag.Reviews = _context.Reviews.AsParallel().Where(r => r.ReviewItem.Equals(item)).ToList();
				ItemTracker tracker = _context.ItemsTracker.AsParallel().Where(it => it.ItemName.Equals(item)).First();
				tracker.TotalViewed++;
				_context.ItemsTracker.Update(tracker);
				await _context.SaveChangesAsync();
			}
			catch(Exception) { }
		}

		[Route("ShoppingCart")]
		public async Task<IActionResult> ViewShoppingCartAsync()
		{
			try
			{
				User u = await um.GetUserAsync(HttpContext.User);
				ViewBag.Cart = _context.ShoppingCart.Where(c => c.UserEmail.Equals(u.Email));
			}
			catch(Exception) { }
			return View(PageNavigation.ShoppingCart);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[Route("AddToCart")]
		public async Task<IActionResult> AddToCartAsync(string itm, int qty)
		{
			if(itm.IsEmpty() || qty == 0)
			{
				await RetrieveItemsAsync(itm);
				return View(PageNavigation.ItemDetailsPage);
			}
			try
			{
				User u = await um.GetUserAsync(HttpContext.User);
				var cart = _context.ShoppingCart.Where(a => a.UserEmail.Equals(u.Email));
				var item = _context.Items.Where(i => i.Name.Equals(itm));
				double price = item.Select(i => i.Price).First();
				string description = item.Select(i => i.Description).First();
				string image = item.Select(i => i.ItemImage).First();
				int count = cart.Count();
				if(cart.Count() >= 1)
				{
					var i = cart.Where(a => a.ItemName.Equals(itm)).First();
					i.Quantity = qty;
					_context.ShoppingCart.Update(i);
				}
				else
				{
					ShoppingCart itemToCart = new ShoppingCart
					{
						UserEmail = u.Email,
						ItemName = itm,
						Quantity = qty,
						Price = price,
						ItemDescription = description,
						Image = image
					};
					_context.ShoppingCart.Add(itemToCart);
				}
				await _context.SaveChangesAsync();
				ViewBag.Cart = cart;
			}
			catch(Exception)
			{
				await RetrieveItemsAsync(itm);
				return View(PageNavigation.ItemDetailsPage);
			}
			return Redirect(PageNavigation.RedirectShoppingCart);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[Route("Purchase")]
		public async Task<IActionResult> PurchaseAsync(string item, int quantity)
		{
			if(item.IsEmpty() || quantity == 0)
			{
				return View(PageNavigation.ItemDetailsPage);
			}
			try
			{
				ItemTracker tracker = _context.ItemsTracker.Where(it => it.ItemName.Equals(item)).First();
				Item[] itms = _context.Items.Where(i => i.Name.Equals(item)).Take(quantity).ToArray();
				tracker.TotalPurchased += quantity;
				_context.ItemsTracker.Update(tracker);
				_context.Items.RemoveRange(itms);
				await _context.SaveChangesAsync();
			}
			catch(Exception) { }
			return Redirect(PageNavigation.RedirectHomePage);
		}
	}
}