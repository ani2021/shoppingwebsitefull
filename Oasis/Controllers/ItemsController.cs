using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oasis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Oasis.Controllers
{
	public class ItemsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Search(string sq)
		{
			return View();
		}

		public IActionResult SelectItem(Item item)
		{
			return View();
		}
	}
}