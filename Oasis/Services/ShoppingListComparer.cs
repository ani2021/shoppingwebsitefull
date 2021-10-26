using Oasis.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Oasis.Services
{
	public class ShoppingListComparer : IEqualityComparer<ShoppingList>
	{
		public bool Equals(ShoppingList x, ShoppingList y)
		{
			if(x.ListName.Equals(y.ListName))
			{
				return true;
			}
			return false;
		}

		public int GetHashCode(ShoppingList obj)
		{
			if(obj == null)
			{
				return 0;
			}
			return obj.ListName == null ? 0 : obj.ListName.GetHashCode();
		}
	}
}