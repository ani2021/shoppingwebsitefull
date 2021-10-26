using System;
using System.Threading.Tasks;
using Oasis.Models;
using Oasis.Services;
using Oasis.Statics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using System.Diagnostics.Eventing.Reader;
using System.Security.Principal;
using Microsoft.AspNetCore.Authorization;

namespace Oasis.Controllers
{
	public class SignInController : Controller
	{
		private readonly UserManager<User> um;
		private readonly SignInManager<User> sm;
		public SignInController(UserManager<User> um, SignInManager<User> sm)
		{
			this.um = um;
			this.sm = sm;
			// this.ms = ms;
		}

		public async Task<IActionResult> IndexAsync()
		{
			try
			{
				if(await um.GetUserAsync(HttpContext.User) == null)
				{
					return View();
				}
				return RedirectToAction(PageNavigation.HomeIndexMethod, PageNavigation.HomeController);
			}
			catch(Exception e) { }
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[Route("Signin")]
		public async Task<IActionResult> SignInAsync(User user)
		{
			try
			{
				var result = await um.FindByEmailAsync(user.Email);
				if(result == null)
				{
					TempData["Error"] = "Wrong Credentails!";
					return View(PageNavigation.SigninPage);
				}
				byte[] r = SecurityService.GetSalt(result.Salt);
				string hash = SecurityService.GenerateHash(user.Email, user.PasswordHash, r);
				if(hash.Equals(result.PasswordHash))
				{
					TempData["Success"] = "You are signed in!";
					await sm.SignInAsync(result, true);
				}
				else
				{
					TempData["Error"] = "Wrong Credentails!";
				}
			}
			catch(Exception e)
			{
				TempData["Error"] = "Something Went Wrong!";
				return View(PageNavigation.ErrorPage);
			}
			return RedirectToAction(PageNavigation.HomeIndexMethod, PageNavigation.HomeController);
		}

		[Authorize]
		[Route("Signout")]
		public async Task<IActionResult> SignOutAsync()
		{
			try
			{
				await sm.SignOutAsync();
				HttpContext.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
				// HttpContext.Abort();
				bool auth = User.Identity.IsAuthenticated;
				TempData.Clear();
			}
			catch(Exception e) { }
			return RedirectToAction(PageNavigation.HomeIndexMethod, PageNavigation.HomeController);
		}
	}
}