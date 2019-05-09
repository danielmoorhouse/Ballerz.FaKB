using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ballerz.Football.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Ballerz.Football.Services;
using Ballerz.Football.Services.Implementations;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace Ballerz.Football
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
              //store connection string as a var
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;
           services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));
           services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();
           services.AddScoped<SignInManager<ApplicationUser>, SignInManager<ApplicationUser>>();
           services.AddScoped<IApplicationUser, ApplicationUserService>();
           services.AddScoped<ICountries, CountriesService>();
           services.AddScoped<ICompetition, CompetitionsService>();
           services.AddScoped<IClubs, ClubsService>();
           services.AddScoped<IClubPerson, ClubPersonService>();
           services.AddScoped<IClubPersonHistory, ClubPersonHistoryService>();
           services.AddScoped<IClubRole, ClubRoleService>();
           services.AddScoped<IPersonImage, PersonImageService>();
           services.AddScoped<IStadiumImage, StadiumImageService>();
           services.AddScoped<ISeason, SeasonsService>();
           services.AddScoped<IStadium, StadiumsService>();
           services.AddScoped<IPost, PostService>();
           services.AddScoped<IForum, ForumService>();
           services.AddScoped<IProfile, ProfileService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDbContext context,
                        RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
               var supportedCultures = new[] { new CultureInfo("en-GB") };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-GB"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            DataSeeder.Initialize(context, userManager, roleManager).Wait();// seed here
        }
    }
}
