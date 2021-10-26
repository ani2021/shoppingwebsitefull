using Oasis.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Oasis.Services
{
	public class ItemComparer : IEqualityComparer<Item>
	{
		public bool Equals(Item x, Item y)
		{
			if(x.Name.Equals(y.Name))
			{
				return true;
			}
			return false;
		}

		public int GetHashCode(Item itm)
		{
			if(itm == null)
			{
				return 0;
			}			
			return itm.Name == null ? 0 : itm.Name.GetHashCode();
		}
	}
}
