using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewSocialNetwork.constraints;
using NewSocialNetwork.Data;
using NewSocialNetwork.Models;

namespace NewSocialNetwork
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

            var supportedCultures = new[]
            {
                new CultureInfo("en"),
                new CultureInfo("de"),
                new CultureInfo("ru")
            };

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("ru");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                options.RequestCultureProviders = new List<IRequestCultureProvider>
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                };
            });

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddViewLocalization();

            services.Configure<SecurityStampValidatorOptions>(options =>
            {
                options.ValidationInterval = TimeSpan.Zero;
            });

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddSignalR();

            services.AddRouting(options =>
            {
                options.ConstraintMap.Add("correctID", typeof(IdConstraint));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            var supportedCultures = new[]
            {
                new CultureInfo("en"),
                new CultureInfo("de"),
                new CultureInfo("ru")
            };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("ru"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseSignalR(routes =>
                {
                    routes.MapHub<Hubs.ChatHub>("/chatHub");
                });

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "index", template: "/", defaults: new { controller = "Home", action = "Index" });
                routes.MapRoute(name: "yorWall", template: "Kek/{id?}", defaults: new { controller = "Home", action = "Index" });
                routes.MapRoute(name: "privacy", template: "Home/Privacy", defaults: new { controller = "Home", action = "Privacy" });
                routes.MapRoute(name: "userWall", template: "Wall/{id?}", defaults: new { controller = "Home", action = "Index" });
                routes.MapRoute(name: "followers", template: "Followers/{id:int?}", defaults: new { controller = "Friend", action = "FollowersList" });
                routes.MapRoute(name: "followUser", template: "Following/{id:int?}", defaults: new { controller = "UserWall", action = "FollowingList" });
                routes.MapRoute(name: "Myfollowers", template: "Followers/{id:int?}", defaults: new { controller = "Friend", action = "FollowersList" });
                routes.MapRoute(name: "MyfollowUser", template: "Following/{id:int?}", defaults: new { controller = "UserWall", action = "FollowingList" });
                routes.MapRoute(name: "Wall", template: "Wall/{id:int?}", defaults: new { controller = "Home", action = "Index" });
                routes.MapRoute(name: "priv", template: "Home/Privacy", defaults: new { controller = "Home", action = "Privacy" });
                routes.MapRoute(name: "followings", template: "Followings/{id:int?}", defaults: new { controller = "UserWall", action = "FollowingList" });
                routes.MapRoute(name: "Userfollowings", template: "UserFollowings/{id:int?}", defaults: new { controller = "UserWall", action = "FollowingList" });
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    , new { myConstraint = new IdConstraint("Home/Index/13") }
                    );
            });
        }
    }
}
