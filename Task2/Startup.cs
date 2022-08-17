using Microsoft.EntityFrameworkCore;
using Task2.Data;
using Task2.Interfaces;

namespace Task2
{
	public class Startup
	{
		private readonly IConfiguration _configuration;

		public Startup(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			var connectionString = _configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<StoreContext>(options =>
				options.UseSqlServer(connectionString));

			services.AddScoped<IShopRepository, ShopRepository>();

			services.AddControllersWithViews();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseExceptionHandler("/Home/Error");

			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
