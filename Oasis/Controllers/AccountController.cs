using System;
using System.Linq;
using Oasis.Models;
using Oasis.Statics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AppContext = Oasis.AppStart.AppContext;
using Oasis.Services;
using System.Web.WebPages;

namespace Oasis.Controllers
{
	public class AccountController : Controller
	{
		private AppContext _context;
		private ItemComparer itemComparer;
		private readonly UserManager<User> um;
		private ShoppingListComparer shoppingListComparer;
		public AccountController(UserManager<User> um)
		{
			this.um = um;
			this._context = new AppContext();
			this.itemComparer = new ItemComparer();
			this.shoppingListComparer = new ShoppingListComparer();
		}

		[Authorize]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[Authorize]
		[Route("AddToList")]
		public async Task<IActionResult> AddToListAsync(string lst, string itm)
		{
			if(itm == null)
			{
				return View();
			}
			try
			{
				User u = await um.GetUserAsync(HttpContext.User);
				AccountService.AddToList(_context, u.Email, lst, itm);
				await _context.SaveChangesAsync();
			}
			catch(Exception e) { }
			return View();
		}

		[HttpGet]
		[Authorize]
		[Route("Lists")]
		public async Task<IActionResult> ViewListsAsync()
		{
			try
			{
				User u = await um.GetUserAsync(HttpContext.User);
				ViewBag.ListItems = _context.ShoppingLists.AsParallel().Where(sl => sl.UserEmail.Equals(u.Email)).OrderBy(sl => sl.ListName).Distinct(shoppingListComparer);
			}
			catch(Exception) { }
			return View(PageNavigation.ShoppingLists);
		}

		[HttpPost]
		[Authorize]
		[Route("CreateList")]
		public async Task<IActionResult> CreateListAsync(ShoppingList lst)
		{
			if(lst == null)
			{
				return View(PageNavigation.HomePage);
			}
			try
			{
				User u = await um.GetUserAsync(HttpContext.User);
				lst.UserEmail = u.Email;
				_context.ShoppingLists.Add(lst);
				await _context.SaveChangesAsync();
			}
			catch(Exception e) { }
			return Redirect(PageNavigation.RedirectHomePage);
		}

		[HttpPost]
		[Authorize]
		[Route("RetrieveList")]
		public async Task<IActionResult> RetrieveListItemsAsync(string listname)
		{
			if(listname.IsEmpty())
			{
				return Redirect(PageNavigation.RedirectShoppingLists);
			}
			try
			{
				User u = await um.GetUserAsync(HttpContext.User);
				var sl = _context.ShoppingLists.AsParallel().Where(sl => sl.UserEmail.Equals(u.Email));
				ViewBag.Items = sl.Where(sl => sl.ListName.Equals(listname));
				ViewBag.ListItems = sl.OrderBy(sl => sl.ListName).Distinct(shoppingListComparer);
				return View(PageNavigation.ShoppingLists);
			}
			catch(Exception) { }
			return View();
		}
	}
}