using Microsoft.AspNetCore.Http;
using Oasis.Configurations;
using Oasis.Models;
using Oasis.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppContext = Oasis.AppStart.AppContext;

namespace Oasis.Services
{
	public class GraphService
	{
		public static HashSet<GraphViewModel> CreateInventoryGraph(AppContext _context, string graphTitle, string inventoryItems, string graphType)
		{
			HashSet<GraphViewModel> gvm = new HashSet<GraphViewModel>();
			try
			{
				HashSet<ItemViewModel> items = new HashSet<ItemViewModel>();
				var group = GetItems(_context, inventoryItems).GroupBy(z => z.Name);
				foreach(var item in group)
				{
					int count = 0;
					Item i = new Item();
					foreach(var c in item)
					{
						i = c;
						count += c.Quantity;
					}
					items.Add(new ItemViewModel { Item = i, Count = count });
				}
				gvm.Add(new GraphViewModel { GraphName = graphTitle, Items = items, GraphType = graphType, Parameter = GraphOptions.Inventory });
			}
			catch(Exception) { }
			return gvm;
		}

		private static ParallelQuery<Item> GetItems(AppContext _context, string inventoryItems)
		{
			return _context.Items.AsParallel().Where(i =>
			{
				foreach(string inventoryItem in inventoryItems.Split(","))
				{
					if(i.Name.Equals(inventoryItem))
					{
						return true;
					}
				}
				return false;
			});
		}

		/*private static HashSet<ItemViewModel> ModItems(ParallelQuery<IGrouping<int, Item>> group)
		{
			HashSet<ItemViewModel> items = new HashSet<ItemViewModel>();
			foreach(var item in group)
			{
				int count = 0;
				Item i = new Item();
				foreach(var c in item)
				{
					i = c;
					count += c.Quantity;
				}
				items.Add(new ItemViewModel { Item = i, Count = count });
			}
			return items;
		}*/

		public static HashSet<GraphViewModel> CreateRatingGraph(AppContext _context, string graphTitle, string inventoryItems, string graphType)
		{
			HashSet<GraphViewModel> gvm = new HashSet<GraphViewModel>(); 
			try
			{
				var group = GetItems(_context, inventoryItems).GroupBy(i => i.ItemId);
				HashSet<ItemViewModel> items = new HashSet<ItemViewModel>();
				foreach(var item in group)
				{
					int count = 0;
					Item i = new Item();
					foreach(var c in item)
					{
						i = c;
						count += c.Quantity;
					}
					items.Add(new ItemViewModel { Item = i, Count = count });
				}
				gvm.Add(new GraphViewModel { GraphName = graphTitle, Items = items, GraphType = graphType, Parameter = GraphOptions.Rating });
			}
			catch(Exception) { }
			return gvm;
		}

		public static HashSet<GraphViewModel> CreateAverageRatingGraph(AppContext _context, string graphTitle, string inventoryItems, string graphType)
		{
			HashSet<GraphViewModel> gvm = new HashSet<GraphViewModel>();
			try
			{
				HashSet<ItemViewModel> items = new HashSet<ItemViewModel>();
				var group = GetItems(_context, inventoryItems).GroupBy(z => z.Name);
				foreach(var item in group)
				{
					double sum = 0;
					Item i = new Item();
					foreach(var c in item)
					{
						i = c;
						sum += c.AverageRating;
					}
					double avg = sum / item.Count();
					items.Add(new ItemViewModel { Item = i, Count = avg });
				}
				gvm.Add(new GraphViewModel { GraphName = graphTitle, Items = items, GraphType = graphType, Parameter = GraphOptions.AverageRating });
			}
			catch(Exception) { }
			return gvm;
		}
	}
}