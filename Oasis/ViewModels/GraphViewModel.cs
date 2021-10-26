using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oasis.ViewModels
{
	public class GraphViewModel
	{
		public string GraphName { get; set; }
		public string GraphType { get; set; }
		public string Parameter { get; set; }
		public HashSet<ItemViewModel> Items { get; set; }
	}
}