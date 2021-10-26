using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Oasis.AppStart;
using Oasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.WebPages;
using AppContext = Oasis.AppStart.AppContext;

namespace Oasis.Services
{
	public class AccountService
	{
		public static bool AddToList(AppContext _context, string email, string lst, string item)
		{
			try
			{
				if(_context != null && !item.IsEmpty() && !lst.IsEmpty())
				{
					ShoppingList list = new ShoppingList { ListName = lst, ItemName = item, UserEmail = email };
					_context.ShoppingLists.Add(list);
					return true;
				}
			}
			catch(Exception) { }
			return false;
		}
	}
}