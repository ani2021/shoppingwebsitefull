using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Oasis.Configurations;
using Oasis.Models;
using Oasis.Services;
using Oasis.Statics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Oasis.Controllers
{
	public class SignUpController : Controller
	{
		private readonly UserManager<User> um;
		private readonly RoleManager<IdentityRole> rm;
		private readonly MessageService ms;
		public SignUpController(UserManager<User> um, RoleManager<IdentityRole> rm)
		{
			this.um = um;
			this.rm = rm;
			this.ms = new MessageService();
			// this.ms = ms;
		}

		public IActionResult Index()
		{
			ViewBag.Roles = rm.Roles;
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[Route("SignUp")]
		public async Task<IActionResult> RegisterAsync(User user)
		{
			if(user == null)
			{
				return View(PageNavigation.SignUpPage);
			}
			/*string em = Regex.Escape(PredefinedRegularExpressions.EmailRejex);
			if(!Regex.IsMatch(user.Email, em))
			{
				return View(PageNavigation.SignUpPage);
			}*/
			try
			{
				byte[] r = SecurityService.GenerateSalt();
				user.PasswordHash = SecurityService.GenerateHash(user.Email, user.PasswordHash, r);
				var result = await um.CreateAsync(user);
				if(!result.Succeeded)
				{
					foreach(var error in result.Errors)
					{
						ModelState.AddModelError(string.Empty, error.Description);
					}
					return View(PageNavigation.SigninPage);
				}
				user.Salt = SecurityService.ToHex(r);
				// SecurityService.WriteToFile(user.Email, user.PasswordHash);
				await um.AddToRoleAsync(user, user.Role);
				string validation = await um.GenerateEmailConfirmationTokenAsync(user);
				var tokenVerificationUrl = Url.Action("VerifyEmail", "Account", new { id = user.Id, token = validation }, Request.Scheme);
				await MessageService.Send(user.Email, "Confirmation", $"Click <a href=\"{tokenVerificationUrl}\">here</a> to verify your email");
			}
			catch(Exception e) { }
			return View(PageNavigation.HomePage);
		}

		[HttpPost]
		public async Task<IActionResult> EmailVerification(string id, string token)
		{
			var user = await um.FindByIdAsync(id);
			var confirmation = await um.ConfirmEmailAsync(user, token);
			if(!confirmation.Succeeded)
			{
				return Content(confirmation.Errors.Select(error => error.Description).Aggregate((allErrors, error) => allErrors += ", " + error));
			}
			return Content("Email confirmed, you can now log in");
		}
	}
}