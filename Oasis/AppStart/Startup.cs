using Oasis.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Oasis.AppStart;

namespace Oasis
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		private readonly RoleManager<IdentityRole> rm;
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc(options =>
			{
				/*options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());*/
			});
			services.AddDbContext<AppContext>(opt =>
			{
				opt.UseSqlite("Data Source=ecommerce.sqlite", optbuild => optbuild.MigrationsAssembly("Oasis"));
			});
			services.AddIdentity<User, IdentityRole>(options =>
			{
				options.User.RequireUniqueEmail = true;
			}).AddEntityFrameworkStores<AppContext>().AddDefaultTokenProviders();
			services.AddSession();
			services.AddDistributedMemoryCache();

			// services.AddHttpClient();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if(env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();
			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();
			app.UseSession();
			app.UseCookiePolicy();

			app.UseEndpoints(endpoints =>
			{
				// endpoints.MapControllerRoute(name: "SignUp", pattern: "SignUp", defaults: new { controller = "SignUp", action = "SignUp" });
				endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}