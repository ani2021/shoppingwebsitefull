using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oasis.Configurations;
using Oasis.Models;
using Oasis.Statics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AppContext = Oasis.AppStart.AppContext;
using Oasis.ViewModels;
using Oasis.Services;
using System.Web.WebPages;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Oasis.Controllers
{
	public class SellerController : Controller
	{
		private readonly AppContext _context;
		private readonly UserManager<User> um;
		public SellerController(UserManager<User> um)
		{
			this.um = um;
			_context = new AppContext();
		}

		[Authorize(Roles = RoleTitle.Seller)]
		[Route("Dashboard")]
		public async Task<IActionResult> DashboardAsync()
		{
			try
			{
				User u = await um.GetUserAsync(HttpContext.User);
				HashSet<GraphViewModel> a = new HashSet<GraphViewModel>();
				_context.Graphs.Where(g => g.SellerEmail.Equals(u.Email)).Select(g => g.Data).ToList().ForEach(d =>
				{
					foreach(var jvm in JsonSerializer.Deserialize<HashSet<GraphViewModel>>(d))
					{
						a.Add(jvm);
					}
				});
				ViewBag.Items = a;
				var items = _context.Items.Where(s => s.SellerEmail.Equals(u.Email));
				ViewBag.ItemNames = _context.Items.Where(s => s.SellerEmail.Equals(u.Email)).Select(i => i.Name).ToHashSet<string>();
			}
			catch(Exception e) { }
			return View(PageNavigation.SellerDashboard);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize(Roles = RoleTitle.Seller)]
		[Route("AddItems")]
		public async Task<IActionResult> AddItems(Item item)
		{
			try
			{
				User u = await um.GetUserAsync(HttpContext.User);
				item.SellerEmail = u.Email;
				var c = _context.Categories.ToList().First(c => c.Name.Equals(item.Category));
				c.NumItems += 1;
				_context.Categories.Update(c);
			}

			catch(Exception e)
			{
				Category nc = new Category { Name = item.Category, NumItems = 1 };
				_context.Categories.Add(nc);
			}
			try
			{
				int q = item.Quantity;
				var items = _context.ItemsTracker.Where(it => it.ItemName.Equals(item.Name)).ToList();
				if(items == null)
				{
					ItemTracker tracker = new ItemTracker
					{
						ItemName = item.Name,
						TotalPurchased = 0,
						TotalViewed = 0
					};
					_context.ItemsTracker.Add(tracker);
					await _context.SaveChangesAsync();
				}
				for(int c = 0; c < q; c++)
				{
					Item i = new Item
					{
						Name = item.Name,
						Description = item.Description,
						Quantity = 1,
						SellerEmail = item.SellerEmail,
						Price = item.Price,
						Category = item.Category,
						DateOnMarket = DateTime.Now
					};
					_context.Items.Add(i);
				}
				await _context.SaveChangesAsync();
			}
			catch(Exception e) { }
			return Redirect(PageNavigation.RedirectSellerDashboard);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize(Roles = RoleTitle.Seller)]
		[Route("CreateGraph")]
		public async Task<IActionResult> CreateGraphAsync(string graphTitle, string parameter, string items, string graphType, int? numItems, DateTime? startDate, DateTime? endDate)
		{
			try
			{
				if(!graphTitle.IsEmpty())
				{
					HashSet<GraphViewModel> a = new HashSet<GraphViewModel>();
					if(startDate == null && endDate == null)
					{
						if(parameter.Equals(GraphOptions.Inventory))
						{
							a = GraphService.CreateInventoryGraph(_context, graphTitle, items, graphType);
						}
						else if(parameter.Equals(GraphOptions.Rating))
						{
							a = GraphService.CreateRatingGraph(_context, graphTitle, items, graphType);
						}
						else if(parameter.Equals(GraphOptions.SellingFrequency))
						{
						}
						else if(parameter.Equals(GraphOptions.TotalSold))
						{
						}
						else if(parameter.Equals(GraphOptions.AverageViews))
						{
						}
						else if(parameter.Equals(GraphOptions.TotalViews))
						{
						}
						else if(parameter.Equals(GraphOptions.TotalRevenue))
						{
						}
						else if(parameter.Equals(GraphOptions.AverageRating))
						{
							a = GraphService.CreateAverageRatingGraph(_context, graphTitle, items, graphType);
						}
					}
					ViewBag.Items = a;
					ViewBag.GraphName = graphTitle;
					User u = await um.GetUserAsync(HttpContext.User);
					Graph g = new Graph { SellerEmail = u.Email, Data = JsonSerializer.Serialize(a), GraphType = graphType };
					_context.Graphs.Add(g);
					await _context.SaveChangesAsync();
				}
			}
			catch(Exception e) { }
			return Redirect(PageNavigation.RedirectSellerDashboard);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize(Roles = RoleTitle.Seller)]
		[Route("RemoveGraph")]
		public async Task<IActionResult> RemoveGraphAsync(string graphName)
		{
			try
			{
				User u = await um.GetUserAsync(HttpContext.User);
				HashSet<GraphViewModel> a = new HashSet<GraphViewModel>();
				Graph g = _context.Graphs.Where(g => g.SellerEmail.Equals(u.Email)).ToList().Where(d =>
				{
					foreach(var jvm in JsonSerializer.Deserialize<HashSet<GraphViewModel>>(d.Data))
					{
						if(jvm.GraphName.Equals(graphName))
						{
							a.Remove(jvm);
							return true;
						}
					}
					return false;
				}).First();
				_context.Graphs.Remove(g);
				await _context.SaveChangesAsync();
				/*_context.Graphs.Where(g => g.SellerEmail.Equals(u.Email)).Select(g => g.Data).ToList().ForEach(d =>
				{
					foreach(var jvm in JsonSerializer.Deserialize<HashSet<GraphViewModel>>(d))
					{
						if(jvm.GraphName.Equals(graphName))
						{
							a.Remove(jvm);
						}
					}
				});*/
				await _context.SaveChangesAsync();
			}
			catch(Exception e) { }
			return Redirect(PageNavigation.RedirectSellerDashboard);
		}
	}
}